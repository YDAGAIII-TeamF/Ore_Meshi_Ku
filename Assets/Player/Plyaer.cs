using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class Plyaer : MonoBehaviour
    {
        public float Plyaer_Speed = 10;

        void Start()
        {

        }

        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            Vector2 direction = new Vector2(x, y).normalized;

            GetComponent<Rigidbody2D>().velocity = direction * Plyaer_Speed;
        }
    }
}
