using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopControl : MonoBehaviour
{
    public GameObject objectToDisable;
    public static bool isDisabled = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDisabled)
        
                objectToDisable.SetActive(false);
            else
                objectToDisable.SetActive(true);
    }
}
