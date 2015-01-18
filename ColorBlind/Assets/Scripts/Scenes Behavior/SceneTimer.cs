using UnityEngine;
using System.Collections;
using System;

public class SceneTimer : MonoBehaviour {

    private float startTime;
    private float restSeconds;
    private int roundedRestSeconds;
    private int displaySeconds;
    private int displayMinutes;
    private GameObject _paramsObject;

    public void Awake()
    {
        startTime = Time.time;
    }

    public void OnGUI()
    {
        //make sure that your time is based on when this script was first called instead of when your game started;

        if (Params.sceneTime == 1)
        {
            Application.LoadLevel("WinScene");
        }

        var guiTime = Time.time - startTime;

        restSeconds = Params.sceneTime - (guiTime);

        //display the timer
        roundedRestSeconds = Mathf.CeilToInt(restSeconds);

        if (roundedRestSeconds == 0)
        {
            Debug.Log("Time is Over");
            Application.LoadLevel("FinishScreen");
        }

        displaySeconds = roundedRestSeconds % 60;
        displayMinutes = roundedRestSeconds / 60;

        var text = String.Format("{0:00}:{1:00}", displayMinutes, displaySeconds);
        //Debug.Log(text);
    }

    
}
