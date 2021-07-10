using System;
using System.Collections;
using System.Threading.Tasks;
using Grpc.Core;
using Script.utils;
using Tech.Takenoko.Grpcspring.Proto;
using UnityEngine;

namespace Script
{
    public abstract class BaseGrpc : MonoBehaviour
    {
        protected Channel Channel;
        protected Player.PlayerClient Client;
        
        private bool isConnecting = false;
        
        protected void Start()
        {
            // Debug.LogFormat("===> Start");
            Channel = new Channel("localhost:6565", ChannelCredentials.Insecure);
            StartCoroutine(Connect());
            // Debug.LogFormat("<=== Start");
        }

        private void Update()
        {
            // Debug.LogFormat("===> Update");
            if (Channel.State != ChannelState.Ready) StartCoroutine(Connect());
            // Debug.LogFormat("<=== Update");
        }

        protected void OnDestroy()
        {
            // Debug.LogFormat("===> OnDestroy");
            this.RunCatching(async (_) => await Channel.ShutdownAsync());
            // Debug.LogFormat("<=== OnDestroy");
        }

        protected virtual void ConnectCompletion() { }

        private IEnumerator Connect()
        {
            if (isConnecting) yield break;
            
            Debug.LogFormat("Start connecting.");
            isConnecting = true;
            Client = null;
            
            while (Client == null)
            {
                yield return null;
                // Debug.LogFormat("Status: {0}", Channel.ConnectAsync().Status);
                switch (Channel.ConnectAsync().Status)
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
                        Client = new Player.PlayerClient(Channel);
                        ConnectCompletion();
                        isConnecting = false;
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

                yield return new WaitForSeconds(3);
            }
        }
    }
}