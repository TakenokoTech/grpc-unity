using Script.repository;
using UnityEngine;

namespace Script
{
    public class Application: MonoBehaviour
    {
        private void OnApplicationQuit()
        {
            Debug.Log("===> OnApplicationQuit");
            GrpcRepository.Destroy();
            Debug.Log("<=== OnApplicationQuit");
        }
    }
}