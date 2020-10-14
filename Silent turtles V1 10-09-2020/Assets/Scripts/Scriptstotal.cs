using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scriptstotal : MonoBehaviour
{

    //scene change

    public void NextSceneP1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        print("Forward one scene");
        Debug.LogWarning("This is what is in Currency before: " + PlayerPrefs.GetInt("StepsCurrency", 0));
        Debug.LogWarning("This is what is in Total before: " + PlayerPrefs.GetInt("StepsTotal", 0));

        int currency = PlayerPrefs.GetInt("StepsCurrency", 0) + PlayerPrefs.GetInt("StepsForCurrency", 0);
        int total = PlayerPrefs.GetInt("StepsTotal", 0) + PlayerPrefs.GetInt("StepsForCurrency", 0);

        PlayerPrefs.SetInt("StepsCurrency", currency);
        PlayerPrefs.SetInt("StepsTotal", total);

        Debug.LogWarning("This is what is in Currency after: " + PlayerPrefs.GetInt("StepsCurrency", 0));
        Debug.LogWarning("This is what is in Total after: " + PlayerPrefs.GetInt("StepsTotal", 0));
    }
    public void NextSceneP2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        print("Forward two scene");
    }
        
    public void BackSceneP1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        print("Backwards one scenes");

    }

    public void BackSceneP2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        print("Backwards two scenes");
       
    }
     public void Exit()
    {
        print("1");
        Application.Quit();
        print("2");
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


    public AudioSource AudioSource;
    public float musicVolume = 1f;




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

    public void ChangeStepsTodayV1()
    {
        PlayerPrefs.SetInt("Steps", 999);
    }
    
    public void ChangeStepsTodayV2()
    {
        PlayerPrefs.SetInt("Steps", 4999);
    }
}
