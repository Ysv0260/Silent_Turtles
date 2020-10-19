using UnityEngine;
using UnityEngine.UI;

public class DevButton : MonoBehaviour
{

    public Button BackM;
    public Button BackD;
    public Button ResetSteps;
    public bool visablity;

    // Start is called before the first frame update
    void Start()
    {
        visablity = false;
        Debug.Log("visability of buttons are " + visablity);
    }

    // Update is called once per frame

    private void Update()
    {
        BackM.gameObject.SetActive(visablity);
        BackD.gameObject.SetActive(visablity);
        ResetSteps.gameObject.SetActive(visablity);
    }

    public void DevClick()
    {
        visablity = true;
        Debug.Log("visability of buttons are " + visablity);
    }

    public void Resetsteps()
    {
        print("ResetButtonPressed");
        PlayerPrefs.SetInt("StepsToday", 0);
        PlayerPrefs.SetInt("stepsYesterday", 0);
        PlayerPrefs.SetInt("StepsThisMonth", 0);
        PlayerPrefs.SetInt("StepsLastMonth", 0);
        PlayerPrefs.SetInt("StepsTotal", 0);
        PlayerPrefs.SetInt("StepsCurrency", 0);
        PlayerPrefs.SetInt("Reward", 0);
    }

    public void BackOneMonth()
    {
        print("BackOneMonthPressed");
        //Change the date to somthing that isnt this month 
        //put steps into last month space within stats
        PlayerPrefs.SetString("Month", "00");
    }

    public void BackOneDay()
    {
        print("BackOneDayPressed");
        //Change the date to somthing that isnt today 
        //put steps into yesterday space within stats
        PlayerPrefs.SetString("Today", "00");
        PlayerPrefs.SetInt("Reward", 0);

    }
}
