using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoplayerController : MonoBehaviour {

    public AudioSource BGM;

    public GameObject objectToPause;

    public VideoPlayer videoPlayer;
    public bool videoIsPlaying;

    public void Start()
    {
        videoIsPlaying = false;
    }
    

    public void videoButtonClicked()
    {
        if(videoIsPlaying == false)
        {
            BGM.Pause();
            videoPlayer.Play();
            videoIsPlaying = true;
            objectToPause.SetActive(false);
        }
        else
        {
            BGM.Play();
            videoIsPlaying = false;
            videoPlayer.Pause();
            objectToPause.SetActive(true);
        }
    }
}
