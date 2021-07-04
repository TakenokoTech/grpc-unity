using System;
using System.Collections;
using System.Threading.Tasks;
using Grpc.Core;
using Tech.Takenoko.Grpcspring.Proto;
using UnityEngine;

namespace Script
{
    public class PlayerChangedService: BaseGrpc
    {
        [SerializeField] private string objUuid;
        [SerializeField] private Vector3 offset;

        private new void Start()
        {
            base.Start();
        }

        protected override void ConnectCompletion()
        {
            var call = Client.Changed(new ChangedRequest {Uuid = objUuid});
            Changed(call);
        }

        private async Task Changed(AsyncServerStreamingCall<ChangedReply> call) {
            while (await call.ResponseStream.MoveNext())
            {
                var uuid = call.ResponseStream.Current.Uuid;
                var position = call.ResponseStream.Current.Position;
                var rotation = call.ResponseStream.Current.Rotation;
                transform.position = new Vector3(position.X + offset.x, position.Y+ offset.y, position.Z+ offset.z);
                transform.eulerAngles = new Vector3(rotation.X, rotation.Y, rotation.Z);
                Debug.LogFormat("uuid: {0}", uuid);
            }
        }
    }
}