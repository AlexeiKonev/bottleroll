using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual
{
    /// <summary>
    /// скрипт цепляем к каждому  осколу 
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]

    public class CellBehavior : MonoBehaviour
    {
       private Rigidbody cellRigibody;
        private void Start()
        {
            cellRigibody = GetComponent<Rigidbody>();
            //делаем   осколок статичным 
            cellRigibody.isKinematic = true;
        }
        private void OnCollisionEnter(Collision collision)
        {
           if(collision.gameObject.CompareTag("Player"))
            {
                //делаем   осколок динамичным
                cellRigibody.isKinematic = false;
            }
        }
    }
}
