using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseScripts
{
    public class MovementControl : MonoBehaviour
    {

        public float speed;
        public Transform cubeT;

        private Transform thisT;
        private float startTime;
        private bool isReady;
    
        // Start is called before the first frame update
        void Start()
        {
            thisT = GetComponent<Transform>();
        }

        public void Initialize()
        {
            isReady = true;
            startTime = Time.time;
            Debug.Log("Player is initialized.");
        }

        public void Disable()
        {
            isReady = false;
            Debug.Log("Player is disabled.");
        }

        // Update is called once per frame
        void Update()
        {
            if (isReady)
            {
                var translationSpeed = 0.25f + (Time.time - startTime) * 0.01f;
                thisT.Translate(Vector3.forward * translationSpeed);

                if (Input.GetKey("a"))
                {
                    cubeT.Translate(Vector3.left * speed);
                }

                if (Input.GetKey("d"))
                {
                    cubeT.Translate(Vector3.right * speed);
                }

                var position = cubeT.position;
                position = new Vector3(Mathf.Clamp(position.x, -11f, 11f), position.y, position.z);
                cubeT.position = position;
            }
        }

    }
}