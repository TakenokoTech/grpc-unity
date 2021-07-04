using System;
using Grpc.Core;
using JetBrains.Annotations;
using Tech.Takenoko.Grpcspring.Proto;
using UnityEngine;

namespace Script
{
    public class PlayerMoveService: BaseGrpc
    {
        [SerializeField] private string objUuid;
        
        private new void Start()
        {
            base.Start();
        }

        protected override void ConnectCompletion()
        {
        }

        private void Update()
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