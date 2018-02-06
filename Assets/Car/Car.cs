using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class Car : MonoBehaviour
    {
        Animator CarAnim;
        Rigidbody Rgb;

        public float Car_Speed;
        public static byte Move =1;
        Vector3 direction;



        void Start()
        {
            CarAnim = GetComponent<Animator>();
            Rgb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            float x = 0;
            float y = 0;
            float z = 0;



            switch (Move)
            {
                case 1:
                    x = Car_Speed;
                    CarAnim.SetBool("Car_Right", true);
                    CarAnim.SetBool("Car_Left", false);
                    CarAnim.SetBool("Car_Up", false);
                    CarAnim.SetBool("Car_Down", false);
                    break;
                case 2:
                    x = -Car_Speed;
                    CarAnim.SetBool("Car_Right", false);
                    CarAnim.SetBool("Car_Left", true);
                    CarAnim.SetBool("Car_Up", false);
                    CarAnim.SetBool("Car_Down", false);
                    break;
                case 3:
                    z = Car_Speed;
                    CarAnim.SetBool("Car_Right", false);
                    CarAnim.SetBool("Car_Left", false);
                    CarAnim.SetBool("Car_Up", true);
                    CarAnim.SetBool("Car_Down", false);
                    break;
                case 4:
                    z = -Car_Speed;
                    CarAnim.SetBool("Car_Right", false);
                    CarAnim.SetBool("Car_Left", false);
                    CarAnim.SetBool("Car_Up", false);
                    CarAnim.SetBool("Car_Down", true);
                    break;
            }

            direction = new Vector3(x, y, z).normalized;

            Rgb.velocity = direction * Car_Speed;
        }
    }
}
