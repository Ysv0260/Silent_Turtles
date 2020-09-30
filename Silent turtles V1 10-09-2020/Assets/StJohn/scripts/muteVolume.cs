using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteVolume : MonoBehaviour
{
    // Start is called before the first frame update
    public void MuteVolume()
    {
        AudioListener.pause = !AudioListener.pause;
        print("On volume worked");
    }

}
