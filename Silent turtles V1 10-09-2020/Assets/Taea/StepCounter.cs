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
            writeStepsMain(steps.ToString());
            text.text = readingStepsMain()+steps.ToString();
            //distanceText.text = (distance * 3.28084).ToString("F2") + " ft";
        }

        private void OnDisable () {
            // Release the pedometer
            Pedometer.Dispose();
            Pedometer = null;
        }


        private void writeStepsMain(String steps)
        {
            StreamWriter sw = new StreamWriter(path + "steps.txt");
            sw.Flush();
            sw.WriteLine(steps);
            
        }

        private string readingStepsMain()
        {
            
            path += @"steps.txt";

            try
            {
                StreamReader sr = new StreamReader(path);
                steps = sr.ReadLine();
                sr.Close();

                return steps;
            }
            catch (Exception e)
            {
                Console.WriteLine("execption:" + e.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}