using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseScripts
{
    public class AppControl : MonoBehaviour
    {
        public MovementControl player;
        public GameObject buttonGameOver;
        public GameObject blockPrefab;
        public GameObject firstBlockPrefab;

        public static AppControl instance;

        public Dictionary<Guid, GameObject> blocks = new Dictionary<Guid, GameObject>();

        private void OnEnable()
        {
            if (instance == null) 
            {
                instance = this;
            } 
            else if(instance == this)
            {
                Destroy(gameObject);
            }
            DontDestroyOnLoad(gameObject);
        }

        public void StopGame()
        {
            var cubeRigidbody = player.cubeT.gameObject.GetComponent<Rigidbody>();
            cubeRigidbody.constraints = RigidbodyConstraints.None;
            player.Disable();
            buttonGameOver.SetActive(true);
            Debug.Log($"Game is stopped at {Time.time}.");
        }

        public void ResetGame()
        {
            var cubeRigidbody = player.cubeT.gameObject.GetComponent<Rigidbody>();
            cubeRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            foreach (var b in blocks.Values)
            {
                Destroy(b);
            }
            blocks.Clear();
            Instantiate(firstBlockPrefab);
            Instantiate(blockPrefab, new Vector3(0f, 0f, 30f), Quaternion.identity);
            player.transform.position = Vector3.zero;
            player.cubeT.position = new Vector3(0f, 1f, 0f);
            player.cubeT.rotation = Quaternion.identity;
            Debug.Log($"Game is reset at {Time.time}.");
        }
    }
}