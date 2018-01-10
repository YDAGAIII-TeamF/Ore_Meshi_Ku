using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeshiScript
{
    public class TestPlayerMove : MonoBehaviour
    {
        Transform thisTransform;
        // Use this for initialization
        void Start()
        {
            thisTransform = gameObject.transform;
        }

        // Update is called once per frame
        void Update()
        {
            thisTransform.position = new Vector3(thisTransform.position.x + (Input.GetAxis("Horizontal") * Time.deltaTime), thisTransform.position.y, thisTransform.position.z + Input.GetAxis("Vertical") * Time.deltaTime);
        }
    }
}