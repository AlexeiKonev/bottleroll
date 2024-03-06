using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual
{
    public class BottleBehavior : MonoBehaviour
    {
        [SerializeField]
         private   GameObject bottleStatic;
        [SerializeField]
        private   GameObject[]  bottleCells;

        private void OnDisable()
        {
            Debug.Log("static bottle disabled");
            foreach(GameObject bottleCell in bottleCells)
            {
                bottleCell.SetActive(true);
                Debug.Log("cell bottle enabled");
            }
        }
    }
}
