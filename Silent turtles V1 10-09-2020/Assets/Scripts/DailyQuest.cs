using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyQuest : MonoBehaviour
{
    public Text Task1;
    public Text Task2;
    public Text Task3;
   

    // Update is called once per frame
    void Update()
    {
        Task1.text = PlayerPrefs.GetInt("StepsToday", 0) + "/1,000";
        Task2.text = PlayerPrefs.GetInt("StepsToday", 0) + "/5,000";
        Task3.text = PlayerPrefs.GetInt("StepsToday", 0) + "/10,000";
        if(PlayerPrefs.GetInt("StepsToday", 0) > 1000)
        {
            Task1.text = PlayerPrefs.GetInt("StepsToday", 0) + "/1,000\nCompleted!";
        }
        if (PlayerPrefs.GetInt("StepsToday", 0) > 5000)
        {
            Task2.text = PlayerPrefs.GetInt("StepsToday", 0) + "/5,000\nCompleted!";
        }
        if (PlayerPrefs.GetInt("StepsToday", 0) > 10000)
        {
            Task3.text = PlayerPrefs.GetInt("StepsToday", 0) + "/10,000\nCompleted!";
        }
    }
}
