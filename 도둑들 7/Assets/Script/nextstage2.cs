﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextstage2 : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D collision)

    {

       SceneManager.LoadScene("Steiz_2");

    }
}
