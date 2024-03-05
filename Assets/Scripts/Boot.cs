using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Hypercasual
{
    public class Boot : MonoBehaviour
    {
        public static  Boot Instance;

        public Score score;

        public Text text;

        public Action actUpdateTextScore;

        // Start is called before the first frame update
        private  void Start()
        {
            if (Instance == null)
            {
            Instance = this;
            }

            score = new Score();

            actUpdateTextScore += UpdateTextScore;

        }

        // Update is called once per frame
        private void Update()
        {
        
        }
        private void UpdateTextScore()
        {
            text.text = score.CountDestroyedBottles.ToString();
        }


    }

    public class Score
    {
        private int countDestroyedBottles;
        public int CountDestroyedBottles { get => countDestroyedBottles; }

        private int costScore = 1;



        public  Score()
        {
            Debug.Log("created Score exemplar");
        }
        public  void AddScore()
        {
            countDestroyedBottles += costScore;
        }

    }
}
