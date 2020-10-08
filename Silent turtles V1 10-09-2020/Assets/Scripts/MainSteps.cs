/* 
*   Pedometer remake 
*   Taea lambert 
*   
*   base from: 
*   Yusuf Olokoba 2018
*   https://github.com/olokobayusuf/Pedometer-API
*/

namespace PedometerU.Tests {
    using System;
    using System.IO;
    using System.Threading;
    using UnityEngine;
    using UnityEngine.UI;

    public class MainSteps : MonoBehaviour {

        public Text Mainsteps;

        private Pedometer Pedometer;

        private void Start () {

            // Create a new pedometer
            Pedometer = new Pedometer(OnStep);
            // Reset UI
            OnStep(PlayerPrefs.GetInt("PlayerSteps", 0), 0);
            


        }

        private void OnStep(int steps, double distance)
        {
            Mainsteps.text = ""+steps;
            //Take the steps and place them within a player prefs
            PlayerPrefs.SetInt("PlayerSteps", steps);
        }
           
       
        private void OnDisable () {
            // Release the pedometer
            Pedometer.Dispose();
            Pedometer = null;
        }

    }
}