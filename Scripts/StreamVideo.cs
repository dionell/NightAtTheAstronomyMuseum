using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StreamVideo : MonoBehaviour {

    public RawImage image;
    private VideoPlayer videoPlayer;
    private VideoSource videoSource;

    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        Application.runInBackground = true;
	}
	


	// Update is called once per frame
	void Update () {
		
	}
}
