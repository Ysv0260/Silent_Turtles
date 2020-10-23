using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUser : MonoBehaviour
{
    //ative
    //lock
    //cost
    public GameObject active1p, active2p, active3p, active4p, active5p;
    public GameObject lock2p, lock3p, lock4p, lock5p;
    public GameObject cost2p, cost3p, cost4p, cost5p;

    // Start is called before the first frame update

    public int charaterNum;

    

    /*public GameObject CharaterCost;
    public GameObject CharaterLock;
    public GameObject CharaterActive;
    public GameObject elfactive;*/

    void Start()
    {
        PlayerPrefs.GetInt("PlayerActive", 1);
        
        //need a if for active 

        if (PlayerPrefs.GetInt("Kight", 0) == 1)
        {
            lock2p.SetActive(false);
            cost2p.SetActive(false);
            
        }
        if (PlayerPrefs.GetInt("Ranger", 0) == 2)
        {
            lock3p.SetActive(false);
            cost3p.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GolumP", 0) == 3)
        {
            lock4p.SetActive(false);
            cost4p.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Char5", 0) == 4)
        {
            lock5p.SetActive(false);
            cost5p.SetActive(false);
        }

      
        //which items have been bought, set lock active to false if player owns
        //set active to whatever player
    }

    public void KightCharater() //buy knight character
    {
        int money = PlayerPrefs.GetInt("StepCurrency", 0);

        if (money >= 50000)
        {
            //Lock2.SetActive(false);
            PlayerPrefs.SetInt("PlayerActive", 2);
            PlayerPrefs.SetInt("Kight", 1);
            /*CharaterCost.SetActive(false);
            CharaterLock.SetActive(false);
            CharaterActive.SetActive(true);
            elfactive.SetActive(false);*/

        }
        if(PlayerPrefs.GetInt("Kight",0) == 1)
        {

        }
        
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
}
