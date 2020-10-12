using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        print("Start button wored ");
    }


    public void Exit()
    {
        //used for testing quit button works on unity 
        //UnityEditor.EditorApplication.isPlaying = false;
        
        Application.Quit();
        print("Exit Button worked");
    }

}
