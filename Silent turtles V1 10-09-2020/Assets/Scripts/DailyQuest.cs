using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyQuest : MonoBehaviour
{
    public Text Task1;
    public Text Task2;
    public Text Task3;
   
    void Start()
    {
        PlayerPrefs.SetFloat("Muti", 1f);
        if (PlayerPrefs.GetString("TodayV2", null) != System.DateTime.Now.ToString("dd"))
        {
            PlayerPrefs.SetString("TodayV2", System.DateTime.Now.ToString("dd"));
            PlayerPrefs.SetInt("Reward", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Task1.text = PlayerPrefs.GetInt("StepsToday", 0) + "/1,000";
        Task2.text = PlayerPrefs.GetInt("StepsToday", 0) + "/5,000";
        Task3.text = PlayerPrefs.GetInt("StepsToday", 0) + "/10,000";
        Reward();
       
    }

    public void Reward()
    {
        int Reward;
        if (PlayerPrefs.GetInt("Reward", 0) == 2)
        {
            
            if (PlayerPrefs.GetInt("StepsToday", 0) >= 10000)
            {
                Debug.Log("Inside 10000 IF");
                Reward = 5000 + PlayerPrefs.GetInt("StepsCurrency", 0);
                PlayerPrefs.SetInt("StepsCurrency", Reward);
                PlayerPrefs.SetInt("Reward", 3);

            }

        }
        if (PlayerPrefs.GetInt("Reward", 0) == 1)
        {
            
            if (PlayerPrefs.GetInt("StepsToday", 0) >= 5000)
            {
                Debug.Log("Inside 5000 IF");
                Reward = 2500 + PlayerPrefs.GetInt("StepsCurrency", 0);
                PlayerPrefs.SetInt("StepsCurrency", Reward);
                PlayerPrefs.SetInt("Reward", 2);

            }
        }
        if (PlayerPrefs.GetInt("Reward",0) == 0)
        {
            
            if (PlayerPrefs.GetInt("StepsToday", 0) >= 1000)
            {
             
                Debug.Log("Inside 1000 IF");
                Reward = 500 + PlayerPrefs.GetInt("StepsCurrency", 0);
                PlayerPrefs.SetInt("StepsCurrency", Reward);
                PlayerPrefs.SetInt("Reward", 1);
            }
        }
    }
}
