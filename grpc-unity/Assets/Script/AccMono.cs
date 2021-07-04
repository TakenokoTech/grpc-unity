using System;
using UnityEngine;
using Random = System.Random;

namespace Script
{
    public class AccMono : MonoBehaviour
    {
        public float accX = 0F;
        public float accZ = 0F;

        private void Start()
        {
            GetComponent<Rigidbody>().AddForce(accX * 30, 0, accZ * 30, ForceMode.Impulse);
        }

        private void LateUpdate()
        {
        }
    }
}