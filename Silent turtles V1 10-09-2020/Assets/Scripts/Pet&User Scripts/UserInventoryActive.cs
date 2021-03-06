﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInventoryActive : MonoBehaviour
{
    public GameObject Char2lock, Char3lock, Char4lock, Char5lock;
    public GameObject Char1active, Char2active, Char3active, Char4active, Char5active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if statements to apply padlocks to the correct characters

        if (PlayerPrefs.GetInt("Char2lock", 1) == 2)
        {
            Char2lock.SetActive(false);
        }
        else
        {
            Char2lock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Char3lock", 1) == 2)
        {
            Char3lock.SetActive(false);
        }
        else
        {
            Char3lock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Char4lock", 1) == 2)
        {
            Char4lock.SetActive(false);
        }
        else
        {
            Char4lock.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Char5lock", 1) == 2)
        {
            Char5lock.SetActive(false);
        }
        else
        {
            Char5lock.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UserActiveState", 1) == 1)
        {
            Char1active.SetActive(true);
            Char2active.SetActive(false);
            Char3active.SetActive(false);
            Char4active.SetActive(false);
            Char5active.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("UserActiveState", 1) == 2 && !Char2lock.activeSelf)
        {
            Char1active.SetActive(false);
            Char2active.SetActive(true);
            Char3active.SetActive(false);
            Char4active.SetActive(false);
            Char5active.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("UserActiveState", 1) == 3 && !Char3lock.activeSelf)
        {
            Char1active.SetActive(false);
            Char2active.SetActive(false);
            Char3active.SetActive(true);
            Char4active.SetActive(false);
            Char5active.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("UserActiveState", 1) == 4 && !Char4lock.activeSelf)
        {
            Char1active.SetActive(false);
            Char2active.SetActive(false);
            Char3active.SetActive(false);
            Char4active.SetActive(true);
            Char5active.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("UserActiveState", 1) == 5 && !Char5lock.activeSelf)
        {
            Char1active.SetActive(false);
            Char2active.SetActive(false);
            Char3active.SetActive(false);
            Char4active.SetActive(false);
            Char5active.SetActive(true);
        }

    }

    //methods for when character buttons are pressed

    public void Active_char1()
    {
        PlayerPrefs.SetInt("SetCharacter", 1);
        PlayerPrefs.SetInt("UserActiveState", 1);
        Char1active.SetActive(true);
    }
    public void Active_char2()
    {
        if (PlayerPrefs.GetInt("Char2lock", 1) == 2)
        {
            PlayerPrefs.SetInt("SetCharacter", 2);
            PlayerPrefs.SetInt("UserActiveState", 2);
            Char2active.SetActive(true);
        }
    }
    public void Active_char3()
    {
        if (PlayerPrefs.GetInt("Char3lock", 1) == 2)
        {
            PlayerPrefs.SetInt("SetCharacter", 3);
            PlayerPrefs.SetInt("UserActiveState", 3);
            Char3active.SetActive(true);
        }
    }
    public void Active_char4()
    {
        if (PlayerPrefs.GetInt("Char4lock", 1) == 2)
        {
            PlayerPrefs.SetInt("SetCharacter", 4);
            PlayerPrefs.SetInt("UserActiveState", 4);
            Char4active.SetActive(true);
        }
    }
    public void Active_char5()
    {
        if (PlayerPrefs.GetInt("Char5lock", 1) == 2)
        {
            PlayerPrefs.SetInt("SetCharacter", 5);
            PlayerPrefs.SetInt("UserActiveState", 5);
            Char5active.SetActive(true);
        }
    }
}
