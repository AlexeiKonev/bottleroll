using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual
{
    /// <summary>
    /// ������ ������� � �������  ������ 
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]

    public class CellBehavior : MonoBehaviour
    {
       private Rigidbody cellRigibody;
        private void Start()
        {
            cellRigibody = GetComponent<Rigidbody>();
            //������   ������� ��������� 
            cellRigibody.isKinematic = true;
        }
        private void OnCollisionEnter(Collision collision)
        {
           if(collision.gameObject.CompareTag("Player"))
            {
                //������   ������� ����������
                cellRigibody.isKinematic = false;
            }
        }
    }
}
