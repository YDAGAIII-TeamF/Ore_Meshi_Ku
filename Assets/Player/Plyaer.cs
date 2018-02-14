using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class Plyaer : MonoBehaviour
    {
        public float Plyaer_Speed;
        public static float Satiety = 1;
        protected Rigidbody RigidBody;

        void Start()
        {
            RigidBody = GetComponent<Rigidbody>();
        }

        void Update()
        {

        }

        protected void Player_Move(){
            float x = Input.GetAxis("Horizontal");
            float y = 0;
            float z = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3(x, y, z).normalized;

            RigidBody.velocity = direction* Plyaer_Speed * Satiety;
        }
    }
}
