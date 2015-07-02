﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesHandler : MonoBehaviour {

    private GameObject livesText;
    private ChangeScene _changeScene;
	// Use this for initialization
	void Start () {
        _changeScene = (ChangeScene)ScriptableObject.CreateInstance("ChangeScene");

        Params.Lives--;
        livesText = GameObject.Find("LivesNumberText");
        livesText.GetComponent<Text>().text = Params.Lives.ToString();
        
	}

    public void Continue()
    {
        if (Params.Lives > 0)
        {
            _changeScene.isComingDeath = true;
            _changeScene.ChangeLevel();
        }
        else
        {
            Application.LoadLevel("FinishScreen");
        }
    }
	
}
