using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual
{
    public class BallSpeed : MonoBehaviour
    {
        [SerializeField] private float desiredAngularVelocity=6;

        [SerializeField] private float accelerationRate=100;

        [SerializeField] private float magnitude ;

        void FixedUpdate()
        {
            magnitude= GetComponent<Rigidbody>().angularVelocity.magnitude;
            if (GetComponent<Rigidbody>().angularVelocity.magnitude < desiredAngularVelocity)
            {
                //scales the acceleration each frame
                GetComponent<Rigidbody>().angularVelocity = GetComponent<Rigidbody>().angularVelocity * accelerationRate * Time.deltaTime;
            }
        }
    }
}
