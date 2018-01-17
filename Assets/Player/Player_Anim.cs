using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class Player_Anim : MonoBehaviour
    {
        Animator Anim;
        int Move;

        void Start()
        {
            Anim = GetComponent<Animator>();
        }

        void Update()
        {
            Move = 0;
            if (Input.GetKey(KeyCode.UpArrow)) Move = 1;
            if (Input.GetKey(KeyCode.DownArrow)) Move = 2;
            if (Input.GetKey(KeyCode.LeftArrow)) Move = 3;
            if (Input.GetKey(KeyCode.RightArrow)) Move = 4;


            switch (Move)
            {
                case 0:
                    Anim.SetBool("UP", false);
                    Anim.SetBool("Down", false);
                    Anim.SetBool("Left", false);
                    Anim.SetBool("Right", false);
                    break;

                case 1:
                    Anim.SetBool("UP", true);
                    break;

                case 2:
                    Anim.SetBool("Down", true);
                    break;

                case 3:
                    Anim.SetBool("Left", true);
                    break;

                case 4:
                    Anim.SetBool("Right", true);
                    break;

                default:
                    break;
                   
            }
            
        }
    }
}
