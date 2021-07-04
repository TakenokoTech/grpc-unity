using System;
using System.Collections;
using System.Threading.Tasks;
using Grpc.Core;
using Tech.Takenoko.Grpcspring.Proto;
using UnityEngine;

namespace Script
{
    public abstract class BaseGrpc : MonoBehaviour
    {
        private Channel _channel;
        protected Player.PlayerClient Client;

        protected void Start()
        {
            Debug.LogFormat("===> Start");
            _channel = new Channel("localhost:6565", ChannelCredentials.Insecure);
            StartCoroutine(Connect());
            Debug.LogFormat("<=== Start");
        }

        private void Update()
        {
            var outX = Math.Abs(transform.position.x) > 100;
            var outY = Math.Abs(transform.position.y) > 100;
            var outZ = Math.Abs(transform.position.z) > 100;
            if (outX || outY || outZ) Destroy(this);
        }

        protected async void OnDestroy()
        {
            Debug.LogFormat("===> OnDestroy");
            try
            {
                await _channel.ShutdownAsync();
            }
            catch (Exception e)
            {
            }
            Debug.LogFormat("<=== OnDestroy");
        }

        protected virtual void ConnectCompletion()
        {
        }

        private IEnumerator Connect()
        {
            while (Client == null)
            {
                Debug.LogFormat("Status: {0}", _channel.ConnectAsync().Status);
                switch (_channel.ConnectAsync().Status)
                {
                    case TaskStatus.Canceled:
                        break;
                    case TaskStatus.Created:
                        break;
                    case TaskStatus.Faulted:
                        break;
                    case TaskStatus.Running:
                        break;
                    case TaskStatus.RanToCompletion:
                        Client = new Player.PlayerClient(_channel);
                        ConnectCompletion();
                        break;
                    case TaskStatus.WaitingForActivation:
                        break;
                    case TaskStatus.WaitingForChildrenToComplete:
                        break;
                    case TaskStatus.WaitingToRun:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                yield return new WaitForSeconds(1);
            }
        }
    }
}