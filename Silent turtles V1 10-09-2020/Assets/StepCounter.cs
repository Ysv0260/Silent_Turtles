/* 
*   Pedometer
*   Copyright (c) 2018 Yusuf Olokoba
*/

namespace PedometerU.Tests {
    using System;
    using System.IO;
    using UnityEngine;
    using UnityEngine.UI;

    public class StepCounter : MonoBehaviour {

        public Text stepstext;
        public Text datatext;
        private Pedometer Pedometer;

        private void Start () {
            // Create a new pedometer
            Pedometer = new Pedometer(OnStep);
            // Reset UI
            if (PlayerPrefs.GetInt("Steps", 0) != 0)
            {
                OnStep(PlayerPrefs.GetInt("Steps", 0), 0);
            }
            else
            {
                OnStep(0, 0);
            }

            
        }

        private void OnStep(int steps, double distance)
        {
            // Display the values // Distance in feet
            //distanceText.text = (distance * 3.28084).ToString("F2") + " ft";            
            stepstext.text = steps.ToString();
            datatext.text = PlayerPrefs.GetInt("Steps", 0).ToString();
            PlayerPrefs.SetInt("Steps", steps);
            PlayerPrefs.SetInt("StepsSave", steps);
        }
           

        private void OnDisable () {


            PlayerPrefs.SetInt("Steps", 0);
            // Release the pedometer
            Pedometer.Dispose();
            Pedometer = null;
        }
       




    }
}