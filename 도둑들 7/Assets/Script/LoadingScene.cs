using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
