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

        public Text text;
        private Pedometer Pedometer;
        private string path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        String steps;

        private void Start () {
            // Create a new pedometer
            Pedometer = new Pedometer(OnStep);
            // Reset UI
            OnStep(0, 0);
        }

        private void OnStep (int steps, double distance) {
            // Display the values // Distance in feet
            //distanceText.text = (distance * 3.28084).ToString("F2") + " ft";

            String stepdata = PlayerPrefs.GetString("Steps_data", "0");


            text.text = steps.ToString() + "   " + stepdata;
        }

        private void OnDisable () {
            // Release the pedometer
            Pedometer.Dispose();
            Pedometer = null;
        }

        private void OnDestroy()
        {
            PlayerPrefs.SetString("Steps_data", steps);
        }

    }
}