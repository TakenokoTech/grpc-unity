using MessagePack;
using UnityEngine;

namespace grpc_magic_onion_server.grpc
{
    [MessagePackObject]
    public class MoveRequest
    {
        [Key(0)] public string uuid;
        [Key(1)] public Vector3 position;
        [Key(2)] public Vector3 rotation;
    }
}