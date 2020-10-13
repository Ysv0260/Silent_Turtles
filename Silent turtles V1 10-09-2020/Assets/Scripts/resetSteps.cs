using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSteps : MonoBehaviour
{
   



    public void Resetsteps()
    {
        PlayerPrefs.SetInt("StepsToday", 0);
        PlayerPrefs.SetInt("stepsYesterday", 0);
        PlayerPrefs.SetInt("StepsThisMonth", 0);
        PlayerPrefs.SetInt("StepsLastMonth", 0);
        PlayerPrefs.SetInt("StepsTotal", 0);
        PlayerPrefs.SetInt("PlayerSteps", 0);
        print(System.DateTime.Now.ToString("dd/MM/yy"));
    }

    /*
     * This is the PlayerPrefs containing the month and date infoamtion 
    string day = System.DateTime.Now.ToString("dd");
    string Month = System.DateTime.Now.ToString("MM");
    PlayerPrefs.SetString("Today", day);
    PlayerPrefs.SetString("Month", Month);
    */
    
    public void BackOneMonth()
    {
        //Change the date to somthing that isnt this month 
        //put steps into last month space within stats
        PlayerPrefs.SetString("Month", "00");
    }

    public void BackOneDay()
    {
        //Change the date to somthing that isnt today 
        //put steps into yesterday space within stats
        PlayerPrefs.SetString("Today", "00");
        
    }

}
