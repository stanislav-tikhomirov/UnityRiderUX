using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseScripts
{
    public class Block : MonoBehaviour
    {
        private Guid id;
    
        // Start is called before the first frame update
        void Start()
        {
            id = Guid.NewGuid();
            AppControl.instance.blocks.Add(id, gameObject);
            Debug.Log($"New block with id {id} is instantiated.");
        }

        private void OnDestroy()
        {
            AppControl.instance.blocks.Remove(id);
            Debug.Log($"Block with id {id} is destroyed.");
        }
        
    }
}