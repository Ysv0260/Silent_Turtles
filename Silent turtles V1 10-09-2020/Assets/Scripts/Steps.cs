/* 
*   Pedometer remake 
*   Taea lambert 
*   
*   base from: 
*   Yusuf Olokoba 2018
*   https://github.com/olokobayusuf/Pedometer-API
*/

namespace PedometerU.Tests
{
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public class Steps : MonoBehaviour
    {

        private Pedometer Pedometer;
        public TextMeshProUGUI Mainsteps;
        public TextMeshProUGUI Multi;



        private void Start()
        {
            // Create a new pedometer
            Pedometer = new Pedometer(OnStep);
            // Reset UI
            OnStep(0, 0);
        }

        private void OnStep(int steps, double distance)
        {
            // Display the values // Distance in Meters to the 2 decimals
            // distanceText.text = (distance).ToString("F2") + " Meter/s";      

            //This is the math outputs the steps to the game 
            int textout = PlayerPrefs.GetInt("StepsCurrency", 0) + steps;
            Mainsteps.text = textout + "";
            PlayerPrefs.SetInt("StepsForCurrency", steps);

            //Take the steps and place them within a player prefs
            int textoutv2 = PlayerPrefs.GetInt("StepsToday", 0) + steps;
            PlayerPrefs.SetInt("Steps", textoutv2);

            // Check the date and move around the steps to right placement
            Chechdate();

            // Check the muliplaction of the Charater
            Multi.text = "×" + PlayerPrefs.GetInt("Multi", 1);

            // Testing to make sure stats are working :-) 
            Debuging(steps);

        }

        private void Debuging(int steps)
        {
            //Steps coming from Main game
            Debug.Log("Steps From main game:  " + steps);

            //Steps Saved within Player Prefs
            Debug.Log("Steps saved in player prefs:  " + PlayerPrefs.GetInt("StepsToday", 0));

            //This does not work it just mush them together do not do math
            Debug.Log("Steps saved + steps V1:   " + PlayerPrefs.GetInt("StepsToday", 0) + steps);

            //This does work as shown when using the debugger tool after biulding
            int TotalStep = PlayerPrefs.GetInt("StepsTotal", 0) + steps;
            Debug.Log("Steps saved + steps V2:   " + TotalStep);

            Debug.Log("This is the day now:  " + System.DateTime.Now.ToString("dd"));
            Debug.Log("This is the day saved:  " + PlayerPrefs.GetString("Today", "can find"));
            Debug.Log("This is the Month now:  " + System.DateTime.Now.ToString("MM"));
            Debug.Log("This is the Month saved:  " + PlayerPrefs.GetString("Month", "can find"));

        }

        private void OnDisable()
        {
            // look at main game the saving of data is kinda causing he multiplcation of data here
            // you are saving it mutiple time each step maybe ?

            PlayerPrefs.SetInt("StepsToday", PlayerPrefs.GetInt("Steps", 0));
            PlayerPrefs.SetInt("StepsThisMonth", PlayerPrefs.GetInt("Steps", 0));

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


            string day = System.DateTime.Now.ToString("dd");
            string Month = System.DateTime.Now.ToString("MM");


            if (PlayerPrefs.GetString("Today", null) != System.DateTime.Now.ToString("dd"))
            {
                PlayerPrefs.SetInt("stepsYesterday", PlayerPrefs.GetInt("StepsToday", 0));
                PlayerPrefs.SetInt("StepsToday", 0);
                PlayerPrefs.SetString("Today", day);

            }

            if (PlayerPrefs.GetString("Month", null) != (System.DateTime.Now.ToString("MM")))
            {
                PlayerPrefs.SetInt("StepsLastMonth", PlayerPrefs.GetInt("StepsThisMonth", 0));
                PlayerPrefs.SetInt("StepsThisMonth", 0);
                PlayerPrefs.SetString("Month", Month);
            }
        }
    }
}