using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowAndHideObjects : MonoBehaviour {

    public void showSun()
    {
        SceneManager.LoadScene("Sun");
    }

    public void showEarth()
    {
        SceneManager.LoadScene("Aurora");
    }

    public void showNebula()
    {
        SceneManager.LoadScene("Nebula");
    }

    public void showBlackHole()
    {
        SceneManager.LoadScene("BlackHole");
    }

    public void showMars()
    {
        SceneManager.LoadScene("Mars");

    }
}
