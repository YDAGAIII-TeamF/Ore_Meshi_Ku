using UnityEngine;
using UnityEngine.AI;

namespace MeshiScript
{
    public class enemy_move : MonoBehaviour
    {

        public Transform target;
        NavMeshAgent agent;

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        void Update()
        {

            agent.SetDestination(target.position);

        }
    }
}
