/* 
*   Pedometer
*   Copyright (c) 2018 Yusuf Olokoba
*/

namespace PedometerU.Tests {

    using UnityEngine;
    using UnityEngine.UI;

    public class StepCounter : MonoBehaviour {

        public Text text;
        private Pedometer Pedometer;

       

        private void Start () {
            // Create a new pedometer
            Pedometer = new Pedometer(OnStep);
            // Reset UI
            OnStep(0, 0);
        }

        private void OnStep (int steps, double distance) {
            // Display the values // Distance in feet
            text.text = steps.ToString();
            //distanceText.text = (distance * 3.28084).ToString("F2") + " ft";
        }

        private void OnDisable () {
            // Release the pedometer
            Pedometer.Dispose();
            Pedometer = null;
        }
    }
}