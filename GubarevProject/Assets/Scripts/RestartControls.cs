﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartControls : MonoBehaviour
{
    public void Restart() 
    {
        SceneManager.LoadScene("Game");
    }
}
