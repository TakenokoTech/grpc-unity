using System;
using UnityEngine;
using Random = System.Random;

namespace Script
{
    public class AccMono : MonoBehaviour
    {
        public float acc = 0F;
        public float limitSpeed = 50;
        
        private Rigidbody _rigidbody = null;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            GetComponent<Rigidbody>().AddForce(acc * 30, 0, acc * 30, ForceMode.Impulse);
        }

        private void LateUpdate()
        {
            if (_rigidbody.velocity.magnitude > limitSpeed)
            {
                var velocity = _rigidbody.velocity;
                velocity = new Vector3(velocity.x / 1.1f, velocity.y, velocity.z / 1.1f);
                _rigidbody.velocity = velocity;
            }
        }
    }
}