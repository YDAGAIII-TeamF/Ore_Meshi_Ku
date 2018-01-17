using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class GoalPointManager : MonoBehaviour
    {
        public List<GameObject> GoalPoints;
        private void Awake()
        {
            Transform thistransform = gameObject.transform;
            GoalPoints = new List<GameObject>();
            for (int i = 0; i < thistransform.childCount; i++) {
                GoalPoints.Add(thistransform.GetChild(i).gameObject);
            }
        }
    }
}