using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class GoalManager : MonoBehaviour
    {
        MeshiScript.GoalPointManager ref_GoalPointManager;
        Transform thisTransform;
        [SerializeField]
        GameObject Prefab_Goal;
        private void Awake()
        {
            ref_GoalPointManager = transform.GetChild(0).gameObject.GetComponent<MeshiScript.GoalPointManager>();
            thisTransform = gameObject.transform;
        }
        // Use this for initialization
        void Start()
        {
            int GoalPointNum = ref_GoalPointManager.GoalPoints.Count;
            int CorrectGoalPointNumber = Random.Range(0, GoalPointNum);
            for (int i = 0; i < GoalPointNum; i++) {
                if (i == CorrectGoalPointNumber)
                {
                    Instantiate<GameObject>(Prefab_Goal, ref_GoalPointManager.GoalPoints[i].transform.position, Quaternion.Euler(90, 0, 0), thisTransform);
                }
            }
        }

        
    }
}
