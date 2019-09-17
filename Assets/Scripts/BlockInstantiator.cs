using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BaseScripts
{
    public class BlockInstantiator : MonoBehaviour
    {

        public GameObject blockPrefab;
        public GateType type;

        private void OnCollisionEnter(Collision other)
        {
            switch (type)
            {
                case GateType.ENTRY:
                    Instantiate(blockPrefab, new Vector3(0f, 0f, transform.parent.position.z + 30f),
                        Quaternion.identity);
                    break;
                case GateType.EXIT:
                    Destroy(transform.parent.gameObject);
                    break;
            }
        }
    }
}


public enum GateType
{
    ENTRY,
    EXIT
}
