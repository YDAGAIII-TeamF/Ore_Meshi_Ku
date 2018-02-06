using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeshiScript
{
    public class Run_GyudonYa : MonoBehaviour
    {
        [SerializeField]
        Transform ActorSpawnPoint;
        [SerializeField]
        GameObject Prefab_Player;
        [SerializeField]
        GameObject Prefab_Enemy;
        // Use this for initialization
        void Start()
        {
            SpawnPlayer();
            StartCoroutine("RutineSpawnEnemy", 3.0f);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private IEnumerator RutineSpawnEnemy(float waitSecond)
        {
            yield return new WaitForSeconds(waitSecond);
            SpawnEnemy();
            yield return null;
        }

        public void SpawnPlayer()
        {
            SpawnActor(Prefab_Player);
        }

        public void SpawnEnemy()
        {
            SpawnActor(Prefab_Enemy);
        }

        private void SpawnActor(GameObject Prefab_Spawn)
        {
            Instantiate<GameObject>(Prefab_Spawn, ActorSpawnPoint.position, ActorSpawnPoint.rotation);
        }
    }
}