using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryActive : MonoBehaviour
{

    public GameObject ActiveGolem, ActiveBear, ActiveCat, ActiveWolf, ActiveFairy, ActiveMushroom;
    public GameObject PadlockGolem, PadlockBear, PadlockCat, PadlockWolf, PadlockMushroom;

    // Start is called before the first frame update
    void Start()
    {
        //Set that it's always on fairy for testing pruposes.
        //PlayerPrefs.SetInt("ActiveState", 1);

        //Set the padlock to 1 for lock, to 2 for unlock
        //PlayerPrefs.SetInt("WolfPadlock", 2);
        //PlayerPrefs.SetInt("BearPadlock", 2);
        //PlayerPrefs.SetInt("MushroomPadlock", 2);
        //PlayerPrefs.SetInt("CatPadlock", 2);
        //PlayerPrefs.SetInt("GolemPadlock", 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("MushroomPadlock", 1) == 2)
        {
            PadlockMushroom.SetActive(false);
        }
        else
        {
            PadlockMushroom.SetActive(true);
        }


        if (PlayerPrefs.GetInt("CatPadlock", 1) == 2)
        {
            PadlockCat.SetActive(false);
        }
        else
        {
            PadlockCat.SetActive(true);
        }


        if (PlayerPrefs.GetInt("WolfPadlock", 1) == 2)
        {
            PadlockWolf.SetActive(false);
        }
        else
        {
            PadlockWolf.SetActive(true);
        }


        if (PlayerPrefs.GetInt("BearPadlock", 1) == 2)
        {
            PadlockBear.SetActive(false);
        }
        else
        {
            PadlockBear.SetActive(true);
        }


        if (PlayerPrefs.GetInt("GolemPadlock", 1) == 2)
        {
            PadlockGolem.SetActive(false);
        }
        else
        {
            PadlockGolem.SetActive(true);
        }

        if (PlayerPrefs.GetInt("ActiveState", 1) == 1)
        {
            ActiveFairy.SetActive(true);
            ActiveMushroom.SetActive(false);
            ActiveCat.SetActive(false);
            ActiveWolf.SetActive(false);
            ActiveBear.SetActive(false);
            ActiveGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 2 && !PadlockMushroom.activeSelf)
        {
            ActiveFairy.SetActive(false);
            ActiveMushroom.SetActive(true);
            ActiveCat.SetActive(false);
            ActiveWolf.SetActive(false);
            ActiveBear.SetActive(false);
            ActiveGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 3 && !PadlockCat.activeSelf)
        {
            ActiveFairy.SetActive(false);
            ActiveMushroom.SetActive(false);
            ActiveCat.SetActive(true);
            ActiveWolf.SetActive(false);
            ActiveBear.SetActive(false);
            ActiveGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 4 && !PadlockWolf.activeSelf)
        {
            ActiveFairy.SetActive(false);
            ActiveMushroom.SetActive(false);
            ActiveCat.SetActive(false);
            ActiveWolf.SetActive(true);
            ActiveBear.SetActive(false);
            ActiveGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 5 && !PadlockBear.activeSelf)
        {
            ActiveFairy.SetActive(false);
            ActiveMushroom.SetActive(false);
            ActiveCat.SetActive(false);
            ActiveWolf.SetActive(false);
            ActiveBear.SetActive(true);
            ActiveGolem.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 6 && !PadlockGolem.activeSelf)
        {
            ActiveFairy.SetActive(false);
            ActiveMushroom.SetActive(false);
            ActiveCat.SetActive(false);
            ActiveWolf.SetActive(false);
            ActiveBear.SetActive(false);
            ActiveGolem.SetActive(true);
        }


    }


    /**
     * 
     * Buttons for pets
     * 
     * **/

    public void InventoryGolemActive()
    {
        if (!PadlockGolem.activeSelf)
        {
            ActiveGolem.SetActive(true);
            PlayerPrefs.SetInt("SetPet", 6);
            PlayerPrefs.SetInt("ActiveState", 6);
        }
    }

    public void InventoryBearActive()
    {
        if (!PadlockBear.activeSelf)
        {
            ActiveBear.SetActive(true);
            PlayerPrefs.SetInt("SetPet", 5);
            PlayerPrefs.SetInt("ActiveState", 5);
        }
    }
    public void InventoryWolfActive()
    {
        if (!PadlockWolf.activeSelf)
        {
            ActiveWolf.SetActive(true);
            PlayerPrefs.SetInt("SetPet", 4);
            PlayerPrefs.SetInt("ActiveState", 4);
        }
    }
    public void InventoryCatActive()
    {
        if (!PadlockCat.activeSelf)
        {
            ActiveCat.SetActive(true);
            PlayerPrefs.SetInt("SetPet", 3);
            PlayerPrefs.SetInt("ActiveState", 3);
        }
    }
    public void InventoryMushroomActive()
    {
        if (!PadlockMushroom.activeSelf)
        {
            ActiveMushroom.SetActive(true);
            PlayerPrefs.SetInt("SetPet", 2);
            PlayerPrefs.SetInt("ActiveState", 2);
        }
    }
    public void InventoryFairyActive()
    { 
        ActiveFairy.SetActive(true);
        PlayerPrefs.SetInt("SetPet", 1);
        PlayerPrefs.SetInt("ActiveState", 1);
    }

}
