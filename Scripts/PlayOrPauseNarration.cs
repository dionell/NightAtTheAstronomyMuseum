using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOrPauseNarration : MonoBehaviour
{

    public AudioSource narrationAudio;

    public bool narrationIsPlaying;

    // Use this for initialization
    void Start()
    {
        narrationIsPlaying = true;
    }

    public void buttonIsClicked()
    {
        if(narrationIsPlaying == true)
        {
            narrationAudio.Pause();
            narrationIsPlaying = false;
        }
        else
        {
            narrationAudio.Play();
            narrationIsPlaying = true;

        }
    }

}

