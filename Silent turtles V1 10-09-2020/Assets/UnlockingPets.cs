using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingPets : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject padlock1;
    public GameObject padlock2;
    public GameObject padlock3;
    public GameObject padlock4;
    public GameObject padlock5;
    public GameObject padlock6;

    public GameObject ActiveState1;
    public GameObject ActiveState2;
    public GameObject ActiveState3;
    public GameObject ActiveState4;
    public GameObject ActiveState5;
    public GameObject ActiveState6;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UnlockedAnimation()
    {
        if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 100000)
        {
            //GolemPet
            padlock1.SetActive(true);
            padlock2.SetActive(true);
            padlock3.SetActive(true);
            padlock4.SetActive(true);
            padlock5.SetActive(true);
            padlock6.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 70000)
        {
            //BearPet
            padlock1.SetActive(false);
            padlock2.SetActive(false);
            padlock3.SetActive(false);
            padlock4.SetActive(false);
            padlock5.SetActive(true);
            padlock6.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 50000)
        {
            //WolfPet
            padlock1.SetActive(false);
            padlock2.SetActive(false);
            padlock3.SetActive(false);
            padlock4.SetActive(true);
            padlock5.SetActive(false);
            padlock6.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 10000)
        {
            //CatPet
            padlock1.SetActive(false);
            padlock2.SetActive(false);
            padlock3.SetActive(true);
            padlock4.SetActive(false);
            padlock5.SetActive(false);
            padlock6.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("StepsCurrency", 0) >= 1000)
        {
            //MushroomPet
            padlock1.SetActive(false);
            padlock2.SetActive(true);
            padlock3.SetActive(false);
            padlock4.SetActive(false);
            padlock5.SetActive(false);
            padlock6.SetActive(false);
        }
        else
        {
            //FairyPet
            padlock1.SetActive(false);
            padlock2.SetActive(true);
            padlock3.SetActive(true);
            padlock4.SetActive(true);
            padlock5.SetActive(true);
            padlock6.SetActive(true);
        }

    }

    public void SetStateToActive()
    {
        if(padlock6 == false)
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
        else if (padlock5 == false)
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
        else if (padlock4 == false)
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
        else if (padlock3 == false)
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
        else if(padlock2 == false)
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
        else if (padlock1 == false)
        {
            //Fairy Active state
            ActiveState1.SetActive(true);
            ActiveState2.SetActive(false);
            ActiveState3.SetActive(false);
            ActiveState4.SetActive(false);
            ActiveState5.SetActive(false);
            ActiveState6.SetActive(false);
            PlayerPrefs.SetInt("ActivePets", 1);
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

}
