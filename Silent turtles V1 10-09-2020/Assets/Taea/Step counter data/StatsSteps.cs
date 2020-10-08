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

    public class StatsSteps : MonoBehaviour {

        public Text Today;
        public Text Yesterday;
        public Text ThisMonth;
        public Text LastMonth;
        public Text Total;

        private Pedometer Pedometer;

        private void Start () {

            // Create a new pedometer
            Pedometer = new Pedometer(OnStep);
            // Reset UI
            //Chechdate();
            OnStep(0, 0);


        }

        private void OnStep(int steps, double distance)
        {
            // Display the values // Distance in feet
            //distanceText.text = (distance * 3.28084).ToString("F2") + " ft";      

            int TodayStep = (steps + PlayerPrefs.GetInt("StepsToday", 0));
            int MonthStep = (steps + PlayerPrefs.GetInt("StepsThisMonth", 0));
            int TotalStep = (steps + PlayerPrefs.GetInt("StepsTotal", 0));
            
            //when there is a new step add to stats page while within stats page
            PlayerPrefs.SetInt("StepsToday", TodayStep);
            PlayerPrefs.SetInt("StepsThisMonth", MonthStep);
            PlayerPrefs.SetInt("StepsTotal", TotalStep);
            
            Today.text = ""+ PlayerPrefs.GetInt("StepsToday", 0); 
            Yesterday.text = "" + PlayerPrefs.GetInt("stepsYesterday", 0);
            ThisMonth.text = "" + PlayerPrefs.GetInt("StepsThisMonth", 0);
            LastMonth.text = "" + PlayerPrefs.GetInt("StepsLastMonth", 0);
            Total.text = "" + PlayerPrefs.GetInt("StepsTotal", 0);


            
           
        }
           

        private void OnDisable () {

            
            
            // Release the pedometer
            Pedometer.Dispose();
            Pedometer = null;
        }


        public void Chechdate()
        {
            /*
             * This will check the date and depending on the date it will move the steps  
             * from player prefs today to the tomrrow player prefs, and same from week and 
             * month, 
             * 
             * Week will be hard ? 
             * maybe convert it into date and use datetime compare ? 
             * 
             * testing will also be hard 
             * - set steps to 100 
             * - set date within the player prefs to one day / month before. 
             * 
             * ///Remove week one maybe 
             * /// tak to group about removing date and mabye last 2 days ?
             * 
             * 
             * //Removed week and placed month now and month before in place. 
             *
             */
            //string Week = System.DateTime.Now.ToString("dd");
            //PlayerPrefs.SetString("week", Week);
            

            string day  = System.DateTime.Now.ToString("dd");
            string Month = System.DateTime.Now.ToString("MM");
            PlayerPrefs.SetString("today", day);
            PlayerPrefs.SetString("month", Month);

            if (PlayerPrefs.GetString(day, null)!=(System.DateTime.Now.ToString("dd")))
            {
                PlayerPrefs.SetInt("stepsYesterday",PlayerPrefs.GetInt("StepsToday", 0));
                PlayerPrefs.SetInt("StepsToday", 0);
            }

            if (PlayerPrefs.GetString("month", null) != (System.DateTime.Now.ToString("MM")))
            {
                PlayerPrefs.SetInt("StepsLastMonth", PlayerPrefs.GetInt("StepsThisMonth", 0));
                PlayerPrefs.SetInt("StepsThisMonth", 0);
            }




            
        }


    }
}