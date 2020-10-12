using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour
{
    public AudioSource AudioSource;
    public float musicVolume = 1f;

    void Update()
    {
        AudioSource.volume = musicVolume;
    }
    public void updateVolume(float volume)
    {
        musicVolume = volume;
        if (volume <= 0.1f)
        {
            print("volume is at low = " + volume);
        }
        else if (volume <= 0.5f)
        {
            print("volume is at medium = " + volume);
        }
        else if (volume <= 1)
        {
            print("volume is at high = " + volume);
        }
        else
        {
            print("volume" + volume);
        }
    }
}
