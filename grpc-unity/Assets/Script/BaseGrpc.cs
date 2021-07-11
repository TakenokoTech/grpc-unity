using UnityEngine;

namespace Script
{
    public abstract class BaseGrpc: MonoBehaviour
    {
        protected void Start()
        {
            // Debug.LogFormat("===> Start");
            // Debug.LogFormat("<=== Start");
        }

        private void Update()
        {
            // Debug.LogFormat("===> Update");
            // Debug.LogFormat("<=== Update");
        }

        protected void OnDestroy()
        {
            // Debug.LogFormat("===> OnDestroy");
            // Debug.LogFormat("<=== OnDestroy");
        }
    }
}