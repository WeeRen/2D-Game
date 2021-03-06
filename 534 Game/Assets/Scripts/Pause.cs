﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public bool isPaused;
    public GameObject canvas;

    private void Start()
    {
        isPaused = false;
        
    }

    // Update is called once per frame
    void Update () {
		
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            Debug.Log("Is Paused is " + isPaused);
        }

        if(isPaused == true)
        {
            Time.timeScale = 0.0f;
            canvas.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            canvas.SetActive(false);
        }


	}

    public void QuitGame ()
    {
        Application.Quit();
    }
}
