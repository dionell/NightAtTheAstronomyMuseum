using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
    
    public void backToMain()
    {
        SceneManager.LoadScene("Main");
    }

}
