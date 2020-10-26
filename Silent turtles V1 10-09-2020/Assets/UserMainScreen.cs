using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMainScreen : MonoBehaviour
{
    public GameObject Char1Ani, Char2Ani, Char3Ani, Char4Ani, Char5Ani;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("SetCharacter", 1) == 1)
        {
            //character 1 AKA Elf
            Char1Ani.SetActive(true);
            Char2Ani.SetActive(false);
            Char3Ani.SetActive(false);
            Char4Ani.SetActive(false);
            Char5Ani.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("SetCharacter", 1) == 2)
        {
            //Character 2 AKA Knight
            Char1Ani.SetActive(false);
            Char2Ani.SetActive(true);
            Char3Ani.SetActive(false);
            Char4Ani.SetActive(false);
            Char5Ani.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("SetCharacter", 1) == 3)
        {
            //Character 3 AKA Ranger
            Char1Ani.SetActive(false);
            Char2Ani.SetActive(false);
            Char3Ani.SetActive(true);
            Char4Ani.SetActive(false);
            Char5Ani.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("SetCharacter", 1) == 4)
        {
            //Character 4 AKA Golem(different from pet)
            Char1Ani.SetActive(false);
            Char2Ani.SetActive(false);
            Char3Ani.SetActive(false);
            Char4Ani.SetActive(true);
            Char5Ani.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("SetCharacter", 1) == 5)
        {
            //Character 5 AKA Centaur
            Char1Ani.SetActive(false);
            Char2Ani.SetActive(false);
            Char3Ani.SetActive(false);
            Char4Ani.SetActive(false);
            Char5Ani.SetActive(true);
        }
        }
}
