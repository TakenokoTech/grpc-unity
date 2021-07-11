using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Script.repository;
using Script.utils;
using Tech.Takenoko.Grpcspring.Proto;
using UnityEngine;

namespace Script
{
    public class PlayerChangedService : BaseGrpc
    {
        public string objUuid;
        public Vector3 offset;

        private AsyncServerStreamingCall<ChangedReply> call = null;
        private Task looper = null;

        private new void Start()
        {
            base.Start();
            looper = Task.Run(() => GrpcRepository.Looper(() => call, () =>
            {
                this.RunCatching(_ => call.Dispose());
                call = null;
            }));
        }

        private void LateUpdate()
        {
            if (call == null)
            {
                Debug.LogFormat("call is null.");
                var routine = ClientRepository.Changed(new ChangedRequest {Uuid = objUuid}, c => { call = c; });
                StartCoroutine(routine);
            }
            this.RunCatching(_ =>
            {
                var position = call.ResponseStream.Current.Position;
                var rotation = call.ResponseStream.Current.Rotation;
                transform.position = new Vector3(position.X + offset.x, position.Y + offset.y, position.Z + offset.z);
                transform.eulerAngles = new Vector3(rotation.X, rotation.Y, rotation.Z);
            });
        }

        protected new void OnDestroy()
        {
            this.RunCatching(_ => looper.Dispose());
            this.RunCatching(_ => call.Dispose());
            base.OnDestroy();
        }
    }
}