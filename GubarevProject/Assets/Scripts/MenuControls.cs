﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayGame()
	{
		SceneManager.LoadScene("Game");
	}    
	public void ExitGame()
	{
		Application.Quit();
	}	
}
