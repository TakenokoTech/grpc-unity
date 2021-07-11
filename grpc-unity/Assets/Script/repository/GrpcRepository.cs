using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Script.utils;
using UnityEngine;

namespace Script.repository
{
    public abstract class GrpcRepository
    {
        protected static readonly Channel GrpcChannel = new Channel("localhost:6565", ChannelCredentials.Insecure);

        private static float _lastConnectTime;

        protected static IEnumerator Connect(Channel channel, Action callback)
        {
            if (channel.State == ChannelState.Ready)
            {
                callback();
                yield break;
            }

            if (Time.time - _lastConnectTime < 3) yield break;
            _lastConnectTime = Time.time;

            var status = channel.ConnectAsync().Status;
            Debug.LogFormat("Status: {0}", status);

            switch (status)
            {
                case TaskStatus.Canceled:
                    break;
                case TaskStatus.Created:
                    break;
                case TaskStatus.Faulted:
                    break;
                case TaskStatus.Running:
                    break;
                case TaskStatus.RanToCompletion:
                    callback();
                    yield break;
                case TaskStatus.WaitingForActivation:
                    break;
                case TaskStatus.WaitingForChildrenToComplete:
                    break;
                case TaskStatus.WaitingToRun:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static void Destroy() => GrpcChannel.RunCatching(async _ => await GrpcChannel.ShutdownAsync());

        public static void Looper<T>(ILooperDelegate<T> d) where T : class
        {
            var tokenSource = new CancellationTokenSource();
            SessionLoop(() =>
            {
                // Debug.LogFormat("State: {0}", GrpcChannel.State);
                if (GrpcChannel.State == ChannelState.Shutdown) tokenSource.Cancel();
                var call = d.GetStreamingCall();
                if (GrpcChannel.State == ChannelState.Ready) return call.ResponseStream.MoveNext();
                throw new InvalidOperationException("bad state.");
            }, d.ConnectError, tokenSource);
        }

        private static async void SessionLoop(Func<Task> function, Action exception, CancellationTokenSource token)
        {
            var failedCount = 0;
            while (!token.IsCancellationRequested)
                try
                {
                    await function();
                    failedCount = 0;
                }
                catch (RpcException e)
                {
                    Debug.LogFormat("RpcException: {0}", e.StatusCode);
                    if (e.StatusCode == StatusCode.Cancelled) token.Cancel();
                    if (failedCount++ > 3) exception();
                    Thread.Sleep(500);
                }
                catch (Exception e)
                {
                    Debug.LogWarning(e);
                    if (failedCount++ > 3) exception();
                    Thread.Sleep(1000);
                }
        }
    }

    public interface ILooperDelegate<T> where T : class
    {
        AsyncServerStreamingCall<T> GetStreamingCall();
        void ConnectError();
    }
}