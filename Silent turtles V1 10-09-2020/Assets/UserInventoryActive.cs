using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInventoryActive : MonoBehaviour
{
    public GameObject Active1, Active2, Active3, Active4, Active5;
    public GameObject Padlock2, Padlock3, Padlock4, Padlock5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if statements to apply padlocks to the correct characters

        if (PlayerPrefs.GetInt("Padlock2", 1) == 2)
        {
            Padlock2.SetActive(false);
        }
        else
        {
            Padlock2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Padlock3", 1) == 2)
        {
            Padlock3.SetActive(false);
        }
        else
        {
            Padlock3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Padlock4", 1) == 2)
        {
            Padlock4.SetActive(false);
        }
        else
        {
            Padlock4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Padlock5", 1) == 2)
        {
            Padlock5.SetActive(false);
        }
        else
        {
            Padlock5.SetActive(true);
        }

        //if statements to correctly apply the active tag

        if (PlayerPrefs.GetInt("ActiveState", 1) == 1)
        {
            Active1.SetActive(true);
            Active2.SetActive(false);
            Active3.SetActive(false);
            Active4.SetActive(false);
            Active5.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 2 && !Padlock2.activeSelf)
        {
            Active1.SetActive(false);
            Active2.SetActive(true);
            Active3.SetActive(false);
            Active4.SetActive(false);
            Active5.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 3 && !Padlock3.activeSelf)
        {
            Active1.SetActive(false);
            Active2.SetActive(false);
            Active3.SetActive(true);
            Active4.SetActive(false);
            Active5.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 4 && !Padlock4.activeSelf)
        {
            Active1.SetActive(false);
            Active2.SetActive(false);
            Active3.SetActive(false);
            Active4.SetActive(true);
            Active5.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("ActiveState", 1) == 5 && !Padlock5.activeSelf)
        {
            Active1.SetActive(false);
            Active2.SetActive(false);
            Active3.SetActive(false);
            Active4.SetActive(false);
            Active5.SetActive(true);
        }
    }

    //methods for when character buttons are pressed

    public void InventoryChar1Active()
    {
        Active1.SetActive(true);
        PlayerPrefs.SetInt("SetCharacter", 1);
        PlayerPrefs.SetInt("ActiveState", 1);
    }
    public void InventoryChar2Active()
    {
        Active2.SetActive(true);
        PlayerPrefs.SetInt("SetCharacter", 2);
        PlayerPrefs.SetInt("ActiveState", 2);
    }
    public void InventoryChar3Active()
    {
        Active3.SetActive(true);
        PlayerPrefs.SetInt("SetCharacter", 3);
        PlayerPrefs.SetInt("ctiveState", 3);
    }
    public void InventoryChar4Active()
    {
        Active4.SetActive(true);
        PlayerPrefs.SetInt("SetCharacter", 4);
        PlayerPrefs.SetInt("ActiveState", 4);
    }
    public void InventoryChar5Active()
    {
        Active5.SetActive(true);
        PlayerPrefs.SetInt("SetCharacter", 5);
        PlayerPrefs.SetInt("ActiveState", 5);
    }

}
