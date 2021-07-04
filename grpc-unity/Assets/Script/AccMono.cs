using System;
using UnityEngine;
using Random = System.Random;

namespace Script
{
    public class AccMono : MonoBehaviour
    {
        public float accX = 0F;
        public float accZ = 0F;
        private void LateUpdate()
        {
            transform.position = new Vector3(
                transform.position.x + accX,
                transform.position.y + 0,
                transform.position.z + accZ
            );
        }

        private void OnCollisionEnter(Collision other)
        {
            // Debug.LogFormat("OnCollisionEnter: {0}", other.gameObject.name);
            switch (other.gameObject.name)
            {
                case "WallX":
                    accZ *= -1; // + (float)(new Random().NextDouble() - 0.5);
                    break;
                case "WallZ":
                    accX *= -1; // + (float)(new Random().NextDouble() - 0.5);
                    break;
                case "ChangedSphere":
                    var tempX = accX;
                    accX = -1 * accZ;
                    accZ = -1 * tempX;
                    break;
            }
        }
    }
}