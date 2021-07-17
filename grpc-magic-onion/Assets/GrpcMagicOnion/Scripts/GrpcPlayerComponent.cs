using System.Threading.Tasks;
using Grpc.Core;
using MagicOnion;
using MagicOnion.Client;
using MessagePack;
using UnityEngine;

namespace GrpcMagicOnion.Scripts
{
    public class GrpcPlayerComponent : MonoBehaviour, IPlayerReceiver
    {
        private string uuid = "sample";
        private Channel _channel;
        private IPlayer _chatHub;

        private void Start()
        {
            _channel = new Channel("localhost:12345", ChannelCredentials.Insecure);
            _chatHub = StreamingHubClient.Connect<IPlayer, IPlayerReceiver>(_channel, this);
            _chatHub.JoinAsync(uuid);
        }

        private async void Update()
        {
           await _chatHub.Move(new MoveRequest {uuid = uuid, position = transform.localPosition, rotation = transform.localEulerAngles});
        }

        private async void OnDestroy()
        {
            _chatHub.LeaveAsync();
            await _chatHub.DisposeAsync();
            await _channel.ShutdownAsync();
        }

        public void OnJoin(string uuid)
        {
            Debug.Log($"OnJoin {uuid}");
        }

        public void Changed(MoveRequest request)
        {
            Debug.Log($"request.position {request.position}");
            Debug.Log($"request.rotation {request.rotation}");
        }
    }
    
    public interface IPlayer : IStreamingHub<IPlayer, IPlayerReceiver>
    {
        Task JoinAsync(string uuid);
        Task LeaveAsync();
        Task<string> Move(MoveRequest request);
    }
    
    public interface IPlayerReceiver
    {
        void OnJoin(string uuid);
        void Changed(MoveRequest request);
    }
    
    [MessagePackObject]
    public class MoveRequest
    {
        [Key(0)] public string uuid;
        [Key(1)] public Vector3 position;
        [Key(2)] public Vector3 rotation;
    }
}
