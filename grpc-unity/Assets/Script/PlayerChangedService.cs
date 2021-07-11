using System;
using Grpc.Core;
using Tech.Takenoko.Grpcspring.Proto;
using UnityEngine;

namespace Script
{
    public class PlayerChangedService: BaseGrpc
    {
        public string objUuid;
        public Vector3 offset;

        private AsyncServerStreamingCall<ChangedReply> call;

        private new void Start()
        {
            base.Start();
        }
        
        protected override void ConnectCompletion()
        {
            call = Client.Changed(new ChangedRequest {Uuid = objUuid});
            Changed();
        }

        protected new void OnDestroy()
        {
            call?.Dispose();
            base.OnDestroy();
        }

        private async void Changed()
        {
            while (Channel.State == ChannelState.Ready)
            {
                try
                {
                    await call.ResponseStream.MoveNext();
                    var position = call.ResponseStream.Current.Position;
                    var rotation = call.ResponseStream.Current.Rotation;
                    transform.position = new Vector3(position.X + offset.x, position.Y+ offset.y, position.Z+ offset.z);
                    transform.eulerAngles = new Vector3(rotation.X, rotation.Y, rotation.Z);
                }
                catch (Exception) { continue; }
            }
        }
    }
}