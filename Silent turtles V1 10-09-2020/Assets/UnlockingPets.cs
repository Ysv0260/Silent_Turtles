﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingPets : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MushroomPadlock;
    public GameObject CatPadlock;
    public GameObject WolfPadlock;
    public GameObject BearPadlock;
    public GameObject GolemPadlock;

    public GameObject ActiveState1;
    public GameObject ActiveState2;
    public GameObject ActiveState3;
    public GameObject ActiveState4;
    public GameObject ActiveState5;
    public GameObject ActiveState6;

    void Start()
    {
        //Set that it's always on fairy for testing pruposes.
        //PlayerPrefs.SetInt("ActiveState", 1);

        //Set the padlock to 1 for lock, to 2 for unlock
        PlayerPrefs.SetInt("WolfPadlock", 2);
        PlayerPrefs.SetInt("BearPadlock", 2);
        PlayerPrefs.SetInt("MushroomPadlock", 2);
        PlayerPrefs.SetInt("CatPadlock", 2);
        PlayerPrefs.SetInt("GolemPadlock", 2);
    }

    // Update is called once per frame
    void Update()
    {
        //Same purpose to check if padlock is open or not but runs frame by frame
        if (PlayerPrefs.GetInt("MushroomPadlock", 1) == 2)
        {
            MushroomPadlock.SetActive(false);
        }
        else
        {
            MushroomPadlock.SetActive(true);
        }


        if (PlayerPrefs.GetInt("CatPadlock", 1) == 2)
        {
            CatPadlock.SetActive(false);
        }
        else
        {
            CatPadlock.SetActive(true);
        }


        if (PlayerPrefs.GetInt("WolfPadlock", 1) == 2)
        {
            WolfPadlock.SetActive(false);
        }
        else
        {
            WolfPadlock.SetActive(true);
        }


        if (PlayerPrefs.GetInt("BearPadlock", 1) == 2)
        {
            BearPadlock.SetActive(false);
        }
        else
        {
            BearPadlock.SetActive(true);
        }

        if (PlayerPrefs.GetInt("ActiveState", 1) == 1)
        {
            ActiveState1.SetActive(true);
            ActiveState2.SetActive(false);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 2)
        {
            ActiveState1.SetActive(false);
            ActiveState2.SetActive(true);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(false);
        }

    }


    public void Unlock_Golem()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 100000)
        {
            //GolemPet
            GolemPurchased = true;
            GolemPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 6);
            PlayerPrefs.SetInt("Activestate", 6);
            PlayerPrefs.SetInt("GolemPadlock", 1);
        }
    }


    public void UnlockedAnimation()
    {



        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 70000)
        {
            //BearPet
            BearPurchased = true;
            BearPadlock.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 50000)
        {
            //WolfPet
            WolfPurchased = true;
            WolfPadlock.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 10000)
        {
            //CatPet
            MushroomPadlock.SetActive(true);
            CatPadlock.SetActive(true);
            WolfPadlock.SetActive(false);
            BearPadlock.SetActive(true);
            GolemPadlock.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 1000)
        {
            //MushroomPet
            MushroomPadlock.SetActive(false);
            CatPadlock.SetActive(true);
            WolfPadlock.SetActive(true);
            BearPadlock.SetActive(true);
            GolemPadlock.SetActive(true);
        }
        else
        {
            //FairyPet
            MushroomPadlock.SetActive(false);
            CatPadlock.SetActive(true);
            WolfPadlock.SetActive(true);
            BearPadlock.SetActive(true);
            GolemPadlock.SetActive(true);
        }

    }




    public void Testingactive(int pet)
    {
        if (pet == 1)
        {
            //Default to fairy
            ActiveState1.SetActive(true);
            ActiveState2.SetActive(false);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 1);
        }
        else if (pet == 2)
        {
            ActiveState1.SetActive(false);
            ActiveState2.SetActive(true);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 2);
        }
    }

    public void SetStateToActive()
    {
        if (GolemPadlock == false)
        {
            //Golem Active state
            ActiveState1.SetActive(false);
            ActiveState2.SetActive(false);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(true);
            PlayerPrefs.SetInt("ActivePets", 6);
        }
        else if (BearPadlock == false)
        {
            //Bear Active state
            ActiveState1.SetActive(false);
            ActiveState2.SetActive(false);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(true);
            ActiveState6.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 5);
        }
        else if (WolfPadlock == false)
        {
            //Wolf Active state
            ActiveState1.SetActive(false);
            ActiveState2.SetActive(false);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(true);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 4);
        }
        else if (CatPadlock == false)
        {
            //Cat Active state
            ActiveState1.SetActive(false);
            ActiveState2.SetActive(false);
            ActiveState3.SetActive(true);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 3);
        }
        else if (MushroomPadlock == false)
        {
            //Mushroom Active state
            ActiveState1.SetActive(false);
            ActiveState2.SetActive(true);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 2);
        }

        else
        {
            //Default to fairy
            ActiveState1.SetActive(true);
            ActiveState2.SetActive(false);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 1);
        }
    }

    public void PetSetActive()
    {
        if (PlayerPrefs.GetInt("PetPurchased", 0) == 6)
        {
            PlayerPrefs.SetInt("SetPet", 6);
            PlayerPrefs.SetInt("ActiveState", 6);
            ActiveState6.SetActive(true);
        }
    }
}
