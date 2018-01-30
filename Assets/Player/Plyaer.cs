using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class Plyaer : MonoBehaviour
    {
        public float Plyaer_Speed;
        public static float Satiety = 1;

        void Start()
        {

        }

        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            float z = 0;

            Vector3 direction = new Vector3(x, y, z).normalized;

            GetComponent<Rigidbody2D>().velocity = direction * Plyaer_Speed * Satiety;
        }
    }
}
