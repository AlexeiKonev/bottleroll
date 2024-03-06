using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual
{
    public class Ball : MonoBehaviour
    {
        

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag == "Enemy")
            {
                Debug.Log("bottle");

                Boot.Instance.score.AddScore();

                Boot.Instance.actUpdateTextScore.Invoke();

                collision.gameObject.SetActive(false);


            }
        }
    }
}
