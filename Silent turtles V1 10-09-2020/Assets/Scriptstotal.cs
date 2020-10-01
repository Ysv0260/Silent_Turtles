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

 

    
    public void updateVolume(float volume)
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

}   
