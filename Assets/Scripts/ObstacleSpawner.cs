using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace BaseScripts
{
    public class ObstacleSpawner : MonoBehaviour
    {
        public GameObject obstaclePrefab;
        private List<GameObject> obstacles;

        // Start is called before the first frame update
        void Start()
        {
            obstacles = new List<GameObject>();
            var thisT = GetComponent<Transform>();
            var amountToSpawn = Mathf.RoundToInt(Random.value * 2f);
            for (int i = 0; i < amountToSpawn; i++)
            {
                obstacles.Add(Instantiate(obstaclePrefab, thisT.position, Quaternion.identity));
            }
        }

        private void OnDestroy()
        {
            foreach (var o in obstacles)
            {
                Destroy(o);
            }
        }
    }
}