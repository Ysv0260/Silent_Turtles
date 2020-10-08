using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetSteps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }


    public void ResetSteps()
    {
        PlayerPrefs.SetInt("StepsToday", 0);
        PlayerPrefs.SetInt("stepsYesterday", 0);
        PlayerPrefs.SetInt("StepsThisMonth", 0);
        PlayerPrefs.SetInt("StepsLastMonth", 0);
        PlayerPrefs.SetInt("StepsTotal", 0);
        print(System.DateTime.Now.ToString("dd/MM/yy"));


        


    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
