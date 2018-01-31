using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class Plyaer : MonoBehaviour
    {
        public float Plyaer_Speed;
        public static float Satiety = 1;
        Rigidbody rigidBody;
        void Start()
        {
            rigidBody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = 0;
            float z = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3(x, y, z).normalized;

            rigidBody.velocity = direction * Plyaer_Speed * Satiety;
        }
    }
}
