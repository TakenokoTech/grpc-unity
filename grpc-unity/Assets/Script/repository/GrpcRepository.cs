using System;
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

        public static void Destroy() => GrpcChannel.RunCatching(async _ => await GrpcChannel.ShutdownAsync());

        public static void Looper<T>(Func<AsyncServerStreamingCall<T>> getCall, Action exception) where T : class
        {
            SessionLoop(() =>
            {
                Debug.LogFormat("State: {0}", GrpcChannel.State);
                if (getCall() != null && GrpcChannel.State == ChannelState.Ready) return getCall().ResponseStream.MoveNext();
                throw new InvalidOperationException("bad state.");
            }, exception);
        }

        private static async void SessionLoop(Func<Task> function, Action exception)
        {
            var failedCount = 0;
            while (true)
                try
                {
                    await function();
                    failedCount = 0;
                }
                catch (Exception e)
                {
                    Debug.LogWarning(e);
                    if (failedCount++ > 3) exception();
                    Thread.Sleep(500);
                }
        }
    }
}