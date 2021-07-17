using System.Collections.Generic;
using UnityEngine;

namespace grpc_magic_onion_server.repository
{
    public class PlayerRepository
    {
        private static Dictionary<string, PlayerModel> state = new Dictionary<string, PlayerModel>();
        private static Dictionary<string, List<IPlayerObserver>> observers = new Dictionary<string, List<IPlayerObserver>>();
        
        public void Change(string uuid, Vector3 position, Vector3 rotation)
        {
            if (!state.ContainsKey(uuid)) state.Add(uuid, new PlayerModel());
            state[uuid] = new PlayerModel { position = position, rotation = rotation };
            // foreach (var playerObserver in observers[uuid]) playerObserver.update(state[uuid]);
        }

        public void AddObserver(string uuid, IPlayerObserver o)
        {
            if (observers.ContainsKey(uuid)) observers.Add(uuid, new List<IPlayerObserver>());
            observers[uuid]?.Add(o);
        }

        public void RemoveObserver(string uuid, IPlayerObserver o)
        {
            observers[uuid]?.Remove(o);
        }

        public class PlayerModel
        {
            public Vector3 position;
            public Vector3 rotation;
        }

        public interface IPlayerObserver
        {
            void update(PlayerModel player);
        }
    }
}