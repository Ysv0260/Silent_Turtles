using System;
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

        /*
         * Check what you have bought 
         * remove lock from ones you have bought
         * remove active from feriy 
         * put active on the right one 
         * 
         * all within start
         * 
         * 
         */
        //get the playerprefs int

        if (PlayerPrefs.GetInt("MushroomPadlock", 1) == 2)
        {
            GolemPadlock.SetActive(false);
        }
        if (PlayerPrefs.GetInt("CatPadlock", 1) == 2)
        {
            GolemPadlock.SetActive(false);
        }
        if (PlayerPrefs.GetInt("WolfPadlock", 1) == 2)
        {
            GolemPadlock.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BearPadlock", 1) == 2)
        {
            GolemPadlock.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GolemPadlock", 1) == 2)
        {
            GolemPadlock.SetActive(false);
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
        else if(PlayerPrefs.GetInt("ActiveState", 1) == 2)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(true);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 3)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(true);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 4)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(true);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 5)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(true);
            ActiveStateGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 6)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {
        Testingactive(PlayerPrefs.GetInt("ActiveState", 1));

    }

    public void Unlock_Golem()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 100000)
        {
            //GolemPet
            GolemPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 6);
            PlayerPrefs.SetInt("ActiveState",6);
            PlayerPrefs.SetInt("GolemPadlock", 2);
        }
    }
    
    public void Unlock_Bear()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 70000)
        {
            BearPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 5);
            PlayerPrefs.SetInt("ActiveState", 5);
            PlayerPrefs.SetInt("BearPadlock", 2);
        }
    }

    public void Unlock_Wolf()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 50000)
        {
            WolfPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 4);
            PlayerPrefs.SetInt("ActiveState", 4);
            PlayerPrefs.SetInt("WolfPadlock", 2);
        }
    }

    public void Unlock_Cat()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 10000)
        {
            BearPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 3);
            PlayerPrefs.SetInt("ActiveState", 3);
            PlayerPrefs.SetInt("CatPadlock", 2);
        }
    }

    public void Unlock_Mushroom()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 70000)
        {
            MushroomPadlock.SetActive(false);
            PlayerPrefs.SetInt("PetPurchased", 2);
            PlayerPrefs.SetInt("ActiveState", 2);
            PlayerPrefs.SetInt("MushroomPadlock", 2);
        }
    }


    public void Testingactive(int pet)
    {
        if(pet == 1)
        {
            //Default to fairy
            ActiveStateFairy.SetActive(true);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 1);
        }
        else if (pet == 2)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(true);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 2);
        }
        else if (pet == 3)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(true);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 3);
        }
        else if (pet == 4)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(true);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 4);
        }
        else if (pet == 5)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(true);
            ActiveStateGolem.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 5);
        }
        else if (pet == 6)
        {
            ActiveStateFairy.SetActive(false);
            ActiveStateMushroom.SetActive(false);
            ActiveStateCat.SetActive(false);
            ActiveStateWolf.SetActive(false);
            ActiveStateBear.SetActive(false);
            ActiveStateGolem.SetActive(true);
            PlayerPrefs.SetInt("ActivePets", 6);
        }
    }

    public void PetSetActive()
    {
        if(PlayerPrefs.GetInt("PetPurchased", 0) == 6)
        {
            PlayerPrefs.SetInt("SetPet", 6);
            PlayerPrefs.SetInt("ActiveState", 6);
            ActiveStateGolem.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("PetPurchased", 0) == 5)
        {
            PlayerPrefs.SetInt("SetPet", 5);
            PlayerPrefs.SetInt("ActiveState", 5);
            ActiveStateBear.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("PetPurchased", 0) == 4)
        {
            PlayerPrefs.SetInt("SetPet", 4);
            PlayerPrefs.SetInt("ActiveState", 4);
            ActiveStateWolf.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("PetPurchased", 0) == 3)
        {
            PlayerPrefs.SetInt("SetPet", 3);
            PlayerPrefs.SetInt("ActiveState", 3);
            ActiveStateCat.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("PetPurchased", 0) == 2)
        {
            PlayerPrefs.SetInt("SetPet", 2);
            PlayerPrefs.SetInt("ActiveState", 2);
            ActiveStateMushroom.SetActive(true);
        }

    }

}
