using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class SceneTimer : MonoBehaviour {

    private float startTime;
    private float restSeconds;
    private int roundedRestSeconds;
    private int displaySeconds;
    private int displayMinutes;
    private GameObject _paramsObject;
    private GameObject timerText;
    public string SceneName;

    public void Awake()
    {
        startTime = Time.time;
        timerText = GameObject.Find("TimerText");
    }

    public void OnGUI()
    {

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
            Application.LoadLevel(SceneName + "Death");
        }

        displaySeconds = roundedRestSeconds % 60;
        displayMinutes = roundedRestSeconds / 60;

        var text = String.Format("{0:00}:{1:00}", displayMinutes, displaySeconds);
        timerText.GetComponent<Text>().text = displaySeconds.ToString();

    }

    
}
