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
    }

    // Update is called once per frame
    void Update()
    {
        Task1.text = PlayerPrefs.GetInt("StepsToday", 0) + "/1,000";
        Task2.text = PlayerPrefs.GetInt("StepsToday", 0) + "/5,000";
        Task3.text = PlayerPrefs.GetInt("StepsToday", 0) + "/10,000";

        int Reward;

        print(PlayerPrefs.GetInt("StepsToday", 0));

        if (PlayerPrefs.GetInt("StepsToday", 0) >= 10000)
        {
            Reward = 10000 + PlayerPrefs.GetInt("StepsCurrency", 0);
            PlayerPrefs.SetInt("StepsCurrency",Reward);
        }
        else if (PlayerPrefs.GetInt("StepsToday", 0) >= 5000)
        {
            Reward = 5000 + PlayerPrefs.GetInt("StepsCurrency", 0);
            PlayerPrefs.SetInt("StepsCurrency", Reward);
        }
        else if(PlayerPrefs.GetInt("StepsToday",0) >= 1000)
        {
            Reward = 1000 + PlayerPrefs.GetInt("StepsCurrency", 0);
            PlayerPrefs.SetInt("StepsCurrency", Reward);
        }
    }
}
