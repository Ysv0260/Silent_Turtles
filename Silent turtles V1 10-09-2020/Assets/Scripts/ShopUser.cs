using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUser : MonoBehaviour
{
    // Start is called before the first frame update


    //StepCurrency

    private int charaterNum;

    public GameObject CharaterCost;
    public GameObject CharaterLock;
    public GameObject CharaterActive;

    public GameObject elfactive;

    void Start()
    {
        
        
    }


    public void KightCharater()
    {
        int money = PlayerPrefs.GetInt("StepCurrency", 0);

        if (money >= 50000)
        {
            

        }
        CharaterCost.SetActive(false);
        CharaterLock.SetActive(false);
        CharaterActive.SetActive(true);
        elfactive.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        // 1 - 5 players 
        //setting int into player prefs 
        PlayerPrefs.SetInt("Player", charaterNum);

        //getting int from player prefs
        PlayerPrefs.GetInt("Player", 1);

        //stepcurrency
        int money = PlayerPrefs.GetInt("StepCurrency", 0);
        if (money >= 50000)
        {

        }
    }

    private void OnDestroy()
    {
        
    }
}
