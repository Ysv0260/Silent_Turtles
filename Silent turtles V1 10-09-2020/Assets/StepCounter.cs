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
        private string path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        public String steps;

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

            if (stepdata == null)
            {
                datatext.text = "NO DATA FOUND";
                print("NO DATA FOUND");
            }
            else
            {
                datatext.text = stepdata;
                print(stepdata);
            }

            

            stepstext.text = steps.ToString();
        }

        private void OnDisable () {
            print("steps OnDisable " + steps.ToString());
            // Release the pedometer
            Pedometer.Dispose();
            Pedometer = null;
        }

        private void OnDestroy()
        {
            print("steps OnDestroy " + steps.ToString());
            String datastepsSave = steps;

            print(steps);
            steps = "REEE";
            print(steps);
            print(datastepsSave);



            PlayerPrefs.SetString("Steps_data", datastepsSave);
        }


    }
}