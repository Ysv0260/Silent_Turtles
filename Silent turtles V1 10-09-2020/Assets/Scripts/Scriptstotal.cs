using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scriptstotal : MonoBehaviour
{
    public AudioSource AudioSource;
    public float musicVolume = 1f;
    public Image Arrow;
    public TextMeshProUGUI RewardText;

    //this will run when the script gets loaded
    private void Start()
    {
        
        if (PlayerPrefs.GetString("TodayV2", null) != System.DateTime.Now.ToString("dd"))
        {
            PlayerPrefs.SetString("TodayV2", System.DateTime.Now.ToString("dd"));
            PlayerPrefs.SetInt("Reward", 0);
        }
    }
    //this method will run each new frame of the game
    void Update()
    {
        Reward();
        Multi();
        AutoStep();
    }
   
    //charater currency saving
    private void CharSave()
    {
        int currency = PlayerPrefs.GetInt("StepsCurrency", 0) + PlayerPrefs.GetInt("StepsForCurrency", 0);
        int total = PlayerPrefs.GetInt("StepsTotal", 0) + PlayerPrefs.GetInt("StepsForCurrency", 0);
        PlayerPrefs.SetInt("StepsCurrency", currency);
        PlayerPrefs.SetInt("StepsTotal", total);
    }

    //scene change


    public void NextScene(int scene)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + scene);
        print("Forward one scene");
        if (SceneManager.GetActiveScene().name == "mainscreen")
        {
            CharSave();
        }
    }
    public void BackScene(int scene)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - scene);
        print("Forward one scene");
        if (SceneManager.GetActiveScene().name == "mainscreen")
        {
            CharSave();
        }
    }

    // Quit the application
    public void Exit()
    {
        Application.Quit();
    }


    //Sound
   
    public void MuteVolume()
    {
        AudioListener.pause = !AudioListener.pause;
        print("Off volume worked");
    }

    public void Fullvolume()
    {
        AudioListener.pause = false;
        print("On volume worked");
    }

    public void UpdateVolume(float volume)
    {
        AudioListener.volume = volume;
        if (volume <= 0.1f)
        {
            print("volume is at low = " + volume);
        }
        else if (volume <= 0.5f)
        {
            print("volume is at medium = " + volume);
        }
        else if (volume <= 1)
        {
            print("volume is at high = " + volume);
        }
        else
        {
            print("volume" + volume);
        }
    }

    //Rewards
    // Display the infomation about reward and keep it on screen for 10 seconds  
    IEnumerator MakeQuestAppear()
    {
        RewardText.gameObject.SetActive(true);
        Arrow.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(10);
        RewardText.gameObject.SetActive(false);
        Arrow.gameObject.SetActive(false);
    }
    public void Reward()
    {

        int Reward;
        //10000 steps
        if (PlayerPrefs.GetInt("Reward", 0) == 2)
        {
            if (PlayerPrefs.GetInt("Steps", 0) >= 10000)
            {
                RewardText.text = "Quest Completed\n+5000";
                StartCoroutine(MakeQuestAppear());
                Reward = 5000 + PlayerPrefs.GetInt("StepsCurrency", 0);
                PlayerPrefs.SetInt("StepsCurrency", Reward);
                PlayerPrefs.SetInt("Reward", 3);
            }
        }
        //5000 steps
        if (PlayerPrefs.GetInt("Reward", 0) == 1)
        {
            if (PlayerPrefs.GetInt("Steps", 0) >= 5000)
            {
                RewardText.text = "Quest Completed\n+2500";
                StartCoroutine(MakeQuestAppear());
                Reward = 2500 + PlayerPrefs.GetInt("StepsCurrency", 0);
                PlayerPrefs.SetInt("StepsCurrency", Reward);
                PlayerPrefs.SetInt("Reward", 2);
            }
        }
        //1000 steps
        if (PlayerPrefs.GetInt("Reward", 0) == 0)
        {
            if (PlayerPrefs.GetInt("Steps", 0) >= 1000)
            {
                RewardText.text = "Quest Completed\n+500";
                StartCoroutine(MakeQuestAppear());
                Reward = 500 + PlayerPrefs.GetInt("StepsCurrency", 0);
                PlayerPrefs.SetInt("StepsCurrency", Reward);
                PlayerPrefs.SetInt("Reward", 1);
            }
        }
    }

    



    //Adhay is going to do this


    //multipler for the players charater

    private void Multi()
    {
        //TODO
        PlayerPrefs.SetFloat("Muti", 1f);
    }

    //auto step for pet
    private void AutoStep()
    {
        //TODO
    }


    //Animation Stuff

    public GameObject Animation;
    
    public void setanimation()
    {
        Animation.SetActive(false);
    }

    
    
    


    
    //Testing

    public void ChangeStepsTodayV1()
    {
        PlayerPrefs.SetInt("StepsCurrency", 999);
        PlayerPrefs.SetInt("Steps", 999);
        PlayerPrefs.SetInt("StepsToday", 999);
    }

    public void ChangeStepsTodayV2()
    {
        PlayerPrefs.SetInt("StepsCurrency", 4999);
        PlayerPrefs.SetInt("Steps", 4999);
        PlayerPrefs.SetInt("StepsToday", 4999);
    }

    public void ButtonPressR()
    {
        print("ButtonClicked right");
    }

    public void ButtonPressL()
    {
        print("ButtonClicked left");
    }
}