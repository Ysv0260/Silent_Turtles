using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetsMainscreen : MonoBehaviour
{
    public GameObject FairyAni, MushroomAni, CatAni, DogAni, BearAni, GolemAni;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("SetPet", 1) == 1)
        {
            //Fairy
            FairyAni.SetActive(true);
            MushroomAni.SetActive(false);
            CatAni.SetActive(false);
            DogAni.SetActive(false);
            BearAni.SetActive(false);
            GolemAni.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("SetPet", 1) == 2)
        {
            //Mushroom
            FairyAni.SetActive(false);
            MushroomAni.SetActive(true);
            CatAni.SetActive(false);
            DogAni.SetActive(false);
            BearAni.SetActive(false);
            GolemAni.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("SetPet", 1) == 3)
        {
            //Cat
            FairyAni.SetActive(false);
            MushroomAni.SetActive(false);
            CatAni.SetActive(true);
            DogAni.SetActive(false);
            BearAni.SetActive(false);
            GolemAni.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("SetPet", 1) == 4)
        {
            //Dog/Wolf
            FairyAni.SetActive(false);
            MushroomAni.SetActive(false);
            CatAni.SetActive(false);
            DogAni.SetActive(true);
            BearAni.SetActive(false);
            GolemAni.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("SetPet", 1) == 5)
        {
            //Bear
            FairyAni.SetActive(false);
            MushroomAni.SetActive(false);
            CatAni.SetActive(false);
            DogAni.SetActive(false);
            BearAni.SetActive(true);
            GolemAni.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("SetPet", 1) == 6)
        {
            //Golem
            FairyAni.SetActive(false);
            MushroomAni.SetActive(false);
            CatAni.SetActive(false);
            DogAni.SetActive(false);
            BearAni.SetActive(false);
            GolemAni.SetActive(true);
        }
    }
}
