using System.Threading.Tasks;
using Grpc.Core;
using Script.repository;
using Script.utils;
using Tech.Takenoko.Grpcspring.Proto;
using UnityEngine;

namespace Script
{
    public class PlayerChangedService : BaseGrpc, ILooperDelegate<ChangedReply>
    {
        public string objUuid;
        public Vector3 offset;

        private AsyncServerStreamingCall<ChangedReply> call = null;
        private Task looper = null;

        private new void Start()
        {
            base.Start();
            looper = Task.Run(() => GrpcRepository.Looper(this));
        }

        private void LateUpdate()
        {
            if (call == null)
            {
                Debug.LogFormat("Disconnect");
                ClientRepository.Changed(new ChangedRequest {Uuid = objUuid}, it => call = it).Execute(this);
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

        public AsyncServerStreamingCall<ChangedReply> GetStreamingCall() => call;

        public void ConnectError()
        {
            Debug.LogFormat("ConnectError");
            this.RunCatching(_ => call.Dispose());
            this.RunCatching(_ => call = null);
        }
    }
}