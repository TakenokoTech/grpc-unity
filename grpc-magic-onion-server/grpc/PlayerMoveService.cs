using System.Threading.Tasks;
using grpc_magic_onion_server.repository;
using MagicOnion;
using MagicOnion.Server.Hubs;

namespace grpc_magic_onion_server.grpc
{
    public class PlayerMoveService: StreamingHubBase<IPlayer, IPlayerReceiver>, IPlayer
    {
        IGroup _room;
        private PlayerRepository playerRepository = new PlayerRepository();
        
        public async Task JoinAsync(string uuid)
        {
            const string roomName = "SampleRoom";
            _room = await Group.AddAsync(roomName);
            Broadcast(_room).OnJoin(uuid);
        }

        public async Task LeaveAsync()
        {
            await _room.RemoveAsync(Context);
        }

        public async Task<string> Move(MoveRequest request)
        {
            var uuid = request.uuid;
            var position = request.position;
            var rotation = request.rotation;
            playerRepository.Change(uuid, position, rotation);
            Broadcast(_room).Changed(request);
            return "sample";
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
}