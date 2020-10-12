using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullVolume: MonoBehaviour
{

    // Start is called before the first frame update
    public void Fullvolume()
    {
        AudioListener.pause = false;
        print("On volume worked");
    }

 }


