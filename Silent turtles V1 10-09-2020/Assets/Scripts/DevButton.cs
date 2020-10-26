using UnityEngine;
using UnityEngine.UI;

public class DevButton : MonoBehaviour
{

    public Button BackM;
    public Button BackD;
    public Button ResetSteps;
    public Button Step999, Step4999, Step9999;

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
        Step999.gameObject.SetActive(visablity);
        Step4999.gameObject.SetActive(visablity);
        Step9999.gameObject.SetActive(visablity);
    }

    public void DevClick()
    {
        visablity = true;
        Debug.Log("visability of buttons are " + visablity);
    }

    public void Resetsteps()
    {
        print("ResetButtonPressed");
        PlayerPrefs.SetInt("Steps", 0);
        PlayerPrefs.SetInt("StepsToday", 0);
        PlayerPrefs.SetInt("stepsYesterday", 0);
        PlayerPrefs.SetInt("StepsThisMonth", 0);
        PlayerPrefs.SetInt("StepsLastMonth", 0);
        PlayerPrefs.SetInt("StepsTotal", 0);
        PlayerPrefs.SetInt("StepsCurrency", 0);
        PlayerPrefs.SetInt("Reward", 0);


        PlayerPrefs.SetInt("SetPet", 1);
        PlayerPrefs.SetInt("ActiveState", 1);
        PlayerPrefs.SetInt("WolfPadlock", 1);
        PlayerPrefs.SetInt("BearPadlock", 1);
        PlayerPrefs.SetInt("MushroomPadlock", 1);
        PlayerPrefs.SetInt("CatPadlock", 1);
        PlayerPrefs.SetInt("GolemPadlock", 1);


        PlayerPrefs.SetInt("SetCharacter", 1);
        PlayerPrefs.SetInt("Char2lock", 1);
        PlayerPrefs.SetInt("Char3lock", 1);
        PlayerPrefs.SetInt("Char4lock", 1);
        PlayerPrefs.SetInt("Char5lock", 1);
    }

    public void Add_1000()
    {
        int total = PlayerPrefs.GetInt("StepsToday", 0) + 1000;
        PlayerPrefs.SetInt("StepsToday", total);
        PlayerPrefs.SetInt("StepsCurrency", total);

    }
    public void Add_5000()
    {
        int total = PlayerPrefs.GetInt("StepsToday", 0) + 5000;
        PlayerPrefs.SetInt("StepsToday", total);
        PlayerPrefs.SetInt("StepsCurrency", total);
    }
    public void Add_10000()
    {
        int total = PlayerPrefs.GetInt("StepsToday", 0) + 10000;
        PlayerPrefs.SetInt("StepsToday", total);
        PlayerPrefs.SetInt("StepsCurrency", total);
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
    }
}
