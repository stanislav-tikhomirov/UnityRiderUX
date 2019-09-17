using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace BaseScripts
{
    public class Obstacle : MonoBehaviour
    {
        private float speed;
        private Transform thisT;

        // Start is called before the first frame update
        void Start()
        {
            thisT = GetComponent<Transform>();
            speed = Random.value;
        }

        // Update is called once per frame
        void Update()
        {
            var translation = Mathf.SmoothStep(-13.5f, 13.5f, Mathf.PingPong(Time.time * speed, 1f));
            //thisT.Translate();
            var position = thisT.position;
            position = new Vector3(translation, position.y, position.z);
            thisT.position = position;
        }

        private void OnCollisionEnter(Collision other)
        {
            AppControl.instance.StopGame();
        }
    }
}