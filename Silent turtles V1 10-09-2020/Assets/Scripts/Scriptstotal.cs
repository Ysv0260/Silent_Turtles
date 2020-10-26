using System;
using System.Collections;
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
    public Image padlockItem;
    public TextMeshProUGUI AutoStep;
    public TextMeshProUGUI StepsCurrency;

    private string SecCompare;
    private bool Flag;

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
        if (SceneManager.GetActiveScene().name == "mainscreen")
        {
            Reward();
            PetAuto();
        }

    }

    public void PetAddStep(int num)
    {

        if(Flag == false)
        {
            int steps = PlayerPrefs.GetInt("StepsCurrency", 0) + num;
            PlayerPrefs.SetInt("StepsCurrency", steps);
            StepsCurrency.text = "" + PlayerPrefs.GetInt("StepsCurrency", 0); 
            Flag = true;
        }
    }


    public void PetAuto()
    {
        string Sec = System.DateTime.Now.ToString("ss");
        if (SecCompare != Sec)
        {
            Flag = false;
            SecCompare = Sec;
        }

        Debug.Log("Sec:" + Sec);
        Debug.Log("Flag:" + Flag);

        switch (PlayerPrefs.GetInt("SetPet", 1))
        {
            case 1:
                AutoStep.text = "0.0/Sec";
                return;
            case 2:
                AutoStep.text = "0.1/Sec";
                if (int.Parse(Sec) % 10 == 0)
                {
                    PetAddStep(1);
                    return;
                }
                return;
            case 3:
                AutoStep.text = "0.2/Sec";
                if (int.Parse(Sec) % 5 == 0)
                {
                    PetAddStep(1);
                    return;
                }
                return;
            case 4:
                AutoStep.text = "0.5/Sec";
                if (int.Parse(Sec) % 2 == 0)
                {
                    PetAddStep(1);
                    return;
                }
                return;
            case 5:
                AutoStep.text = "1/Sec";
                if (int.Parse(Sec) % 1 == 0)
                {
                    PetAddStep(1);
                    return;
                }
                return;
            case 6:
                AutoStep.text = "2/Sec";
                if (int.Parse(Sec) % 1 == 0)
                {
                    PetAddStep(2);
                    return;
                }
                return;
        }
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
        print("Forward " + scene + " scene");
        if (SceneManager.GetActiveScene().name == "mainscreen")
        {
            CharSave();
        }
    }
    public void BackScene(int scene)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - scene);
        print("Forward " + scene + " scene");
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
            if (PlayerPrefs.GetInt("StepsToday", 0) >= 10000)
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
            if (PlayerPrefs.GetInt("StepsToday", 0) >= 5000)
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
            if (PlayerPrefs.GetInt("StepsToday", 0) >= 1000)
            {
                RewardText.text = "Quest Completed\n+500";
                StartCoroutine(MakeQuestAppear());
                Reward = 500 + PlayerPrefs.GetInt("StepsCurrency", 0);
                PlayerPrefs.SetInt("StepsCurrency", Reward);
                PlayerPrefs.SetInt("Reward", 1);
            }
        }
    }





    //Testing


    public void ButtonPressR()
    {
        print("ButtonClicked right");
    }

    public void ButtonPressL()
    {
        print("ButtonClicked left");
    }

}