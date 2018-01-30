using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class CarManager : MonoBehaviour
    {
        [SerializeField]
        GameObject Prefab_Car;
        [SerializeField]
        List<Transform> CarSpawnPoint;
        [SerializeField]
        Transform CarSpawnParentTransform;

        [SerializeField]
        float minTime;
        [SerializeField]
        float maxTime;
        float nextTime;
        float nowTime;

        [SerializeField]
        List<Transform> CarDespawnPoint;
        [SerializeField]
        GameObject Prefab_CarDespawnPoint;
        [SerializeField]
        Transform CarDespawnParentTransform;

        // Use this for initialization
        private void Awake()
        {
            //車生成地点関連処理
            CarSpawnPoint = new List<Transform>();

            for(int i = 0;i < CarSpawnParentTransform.childCount; i++)
            {
                CarSpawnPoint.Add(CarSpawnParentTransform.GetChild(i).transform);
            }

            if(minTime < 0.0f)
            {
                minTime = 0.0f;
            }

            if(minTime > maxTime)
            {
                maxTime = minTime;
            }
            //車破棄地点関連処理
            CarDespawnPoint = new List<Transform>();

            for(int i = 0; i < CarDespawnParentTransform.childCount; i++)
            {
                CarDespawnPoint.Add(CarDespawnParentTransform.GetChild(i));
                InstantiateDespawnPoint(i);
            }

        }

        // Update is called once per frame
        void Update()
        {
            nowTime += Time.deltaTime;
            if (nowTime >= nextTime)
            {
                SpawnCar(Random.Range(0, CarDespawnPoint.Count));
                nowTime = 0.0f;
                nextTime = Random.Range(minTime, maxTime);
            }
        }

        void SpawnCar(int spawnIndex)
        {
            Instantiate<GameObject>(Prefab_Car,CarSpawnPoint[spawnIndex].position,Quaternion.Euler(90,0,0));
        }

        void InstantiateDespawnPoint(int spawnIndex)
        {
            Instantiate<GameObject>(Prefab_CarDespawnPoint, CarDespawnPoint[spawnIndex].position, Quaternion.Euler(0, 0, 0));
        }
    }
}