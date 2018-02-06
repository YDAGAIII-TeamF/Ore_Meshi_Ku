using UnityEngine;
using UnityEngine.AI;
namespace MeshiScript
{
    /// <summary>
    /// 敵の動き(ナビメッシュエージェント)
    /// </summary>
    public class Enemy_Move : MonoBehaviour
    {
        public Transform target; //追いかけるオブジェクト
        NavMeshAgent agent;

        void Start()
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
            agent = GetComponent<NavMeshAgent>();
        }

        void FixedUpdate()
        {
            agent.SetDestination(target.position);
        }
    }
}
