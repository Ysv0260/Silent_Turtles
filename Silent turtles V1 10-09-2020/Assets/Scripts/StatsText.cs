using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatsText : MonoBehaviour
{
    public Text Today;
    public Text Yesterday;
    public Text ThisMonth;
    public Text LastMonth;
    public Text Total;
    

    // Update is called once per frame
    void Update()
    {
        Today.text = "" + PlayerPrefs.GetInt("StepsToday", 0);
        Yesterday.text = "" + PlayerPrefs.GetInt("stepsYesterday", 0);
        ThisMonth.text = "" + PlayerPrefs.GetInt("StepsThisMonth", 0);
        LastMonth.text = "" + PlayerPrefs.GetInt("StepsLastMonth", 0);
        Total.text = "" + PlayerPrefs.GetInt("StepsTotal", 0);
    }
}
