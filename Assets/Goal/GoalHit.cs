using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeshiScript
{
    public class GoalHit : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Goal");
            }
        }
    }

}