﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour {

    //called from starting button.
    public void StartGame()
    {
        Platform.instance.game.StartGame();
        this.transform.GetChild(0).gameObject.SetActive(false);
        this.transform.GetChild(1).gameObject.SetActive(false);
    }

    //called from platform.gamehandler
    public void GameOver()
    {
        Debug.Log("game over");
        this.transform.GetChild(1).gameObject.SetActive(true);
    }

    public void StartAgain()
    {
        Debug.Log("tusa bastım");
        SceneManager.LoadScene(0);
    }
	
}
