using System;
using Tech.Takenoko.Grpcspring.Proto;

namespace Script
{
    public class PlayerMoveService: BaseGrpc
    {
        public string objUuid;
        
        private new void Start()
        {
            base.Start();
        }

        private void LateUpdate()
        {
            Client?.Move(new MoveRequest
            {
                Uuid = objUuid,
                Position = new Vector3_
                {
                    X = transform.position.x,
                    Y = transform.position.y,
                    Z = transform.position.z
                },
                Rotation = new Vector3_
                {
                    X = transform.eulerAngles.x,
                    Y = transform.eulerAngles.y,
                    Z = transform.eulerAngles.z
                }
            });
        }
    }
}