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

    public GameObject ActiveStateFairy;
    public GameObject ActiveStateMushroom;
    public GameObject ActiveStateCat;
    public GameObject ActiveStateWolf;
    public GameObject ActiveStateBear;
    public GameObject ActiveStateGolem;

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

        if (PlayerPrefs.GetInt("GolemPadlock", 1) == 2)
        {
            GolemPadlock.SetActive(false);
        }
        else
        {
            GolemPadlock.SetActive(true);
        }


        if (PlayerPrefs.GetInt("ActiveState", 1) == 1)
        {
            ActiveStateFairy.SetActive(true);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 2 && !MushroomPadlock.activeSelf)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(true);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 3 && !CatPadlock.activeSelf)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(true);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 4 && !WolfPadlock.activeSelf)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(true);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 5 && !BearPadlock.activeSelf)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(true);
            ActiveStateGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 6 && !GolemPadlock.activeSelf)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(true);
        }

    }


    public void Unlock_Golem()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 100000)
        {
            //GolemPet
            GolemPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 6);
            PlayerPrefs.SetInt("Activestate", 6);
            PlayerPrefs.SetInt("GolemPadlock", 2);

        }
    }

    public void Unlock_Bear()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 70000)
        {
            //BearPet
            BearPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 5);
            PlayerPrefs.SetInt("Activestate", 5);
            PlayerPrefs.SetInt("BearPadlock", 2);

        }
    }

    public void Unlock_Wolf()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 50000)
        {
            //WolfPet
            WolfPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 4);
            PlayerPrefs.SetInt("Activestate", 4);
            PlayerPrefs.SetInt("WolfPadlock", 2);

        }
    }

    public void Unlock_Cat()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 10000)
        {
            //CatPet
            CatPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 3);
            PlayerPrefs.SetInt("Activestate", 3);
            PlayerPrefs.SetInt("CatPadlock", 2);

        }
    }

    public void Unlock_Mushroom()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 1000)
        {
            //MushroommPet
            MushroomPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 2);
            PlayerPrefs.SetInt("Activestate", 2);
            PlayerPrefs.SetInt("MushroomPadlock", 2);

        }
    }




    public void GolemSetActive()
    {
        if (PlayerPrefs.GetInt("GolemPadlock", 1) == 2)
        {
            PlayerPrefs.SetInt("SetPet", 6);
            PlayerPrefs.SetInt("ActiveState", 6);
            ActiveStateGolem.SetActive(true);
        }
    }
    public void BearSetActive()
    {
        if (PlayerPrefs.GetInt("BearPadlock", 1) == 2)
        {
            PlayerPrefs.SetInt("SetPet", 5);
            PlayerPrefs.SetInt("ActiveState", 5);
            ActiveStateBear.SetActive(true);
        }
    }
    public void WolfSetActive()
    {
        if (PlayerPrefs.GetInt("WolfPadlock", 1) == 2)
        {
            PlayerPrefs.SetInt("SetPet", 4);
            PlayerPrefs.SetInt("ActiveState", 4);
            ActiveStateWolf.SetActive(true);
        }
    }
    public void CatSetActive()
    {
        if (PlayerPrefs.GetInt("CatPadlock", 1) == 2)
        {
            PlayerPrefs.SetInt("SetPet", 3);
            PlayerPrefs.SetInt("ActiveState", 3);
            ActiveStateCat.SetActive(true);
        }
    }
    public void MushroomSetActive()
    {
        if (PlayerPrefs.GetInt("MushroomPadlock", 1) == 2)
        {
            PlayerPrefs.SetInt("SetPet", 2);
            PlayerPrefs.SetInt("ActiveState", 2);
            ActiveStateMushroom.SetActive(true);
        }
    }
    public void FairySetActive()
    {
            PlayerPrefs.SetInt("SetPet", 1);
            PlayerPrefs.SetInt("ActiveState", 1);
            ActiveStateFairy.SetActive(true);
    }

}