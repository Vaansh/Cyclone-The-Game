using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene("Home");
    }
    public void Again()
    {
        SceneManager.LoadScene("Play");
    }
}
