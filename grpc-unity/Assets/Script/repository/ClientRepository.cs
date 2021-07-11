using System;
using System.Collections;
using Grpc.Core;
using Script.utils;
using Tech.Takenoko.Grpcspring.Proto;

namespace Script.repository
{
    public class ClientRepository : GrpcRepository
    {
        public static IEnumerator Move(MoveRequest request)
        {
            return Connect(client => client.Move(request));
        }

        public static IEnumerator Changed(ChangedRequest request, Action<AsyncServerStreamingCall<ChangedReply>> callback)
        {
            return Connect(client => callback(client.Changed(request)));
        }

        private static IEnumerator Connect(Action<Player.PlayerClient> callback)
        {
            return GrpcUtils.Connect(GrpcChannel, () => callback(new Player.PlayerClient(GrpcChannel)));
        }
    }
}