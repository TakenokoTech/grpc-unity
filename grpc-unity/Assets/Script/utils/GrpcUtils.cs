using System;
using System.Collections;
using System.Threading.Tasks;
using Grpc.Core;
using UnityEngine;

namespace Script.utils
{
    public static class GrpcUtils
    {
        public static IEnumerator Connect(Channel channel, Action callback)
        {
            if (channel.State == ChannelState.Ready)
            {
                callback();
                yield break;
            }

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
    }
}