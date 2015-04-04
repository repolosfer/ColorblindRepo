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
    public int SceneTime;

    public void Awake()
    {
        startTime = Time.time;
        timerText = GameObject.Find("TimerText");
        this.SceneTime = this.SceneTime - Params.difficulty;
    }

    public void OnGUI()
    {
        Params.TimeRemaining = SceneTime;
        if (this.SceneTime == 1)
        {
            Application.LoadLevel("WinScene");
        }
        
        var guiTime = Time.time - startTime;

        restSeconds = this.SceneTime - (guiTime);

        //display the timer
        roundedRestSeconds = Mathf.CeilToInt(restSeconds);
        Params.TimeRemaining = roundedRestSeconds;
        if (roundedRestSeconds == 0)
        {
            
            Application.LoadLevel(SceneName + "Death");
        }

        displaySeconds = roundedRestSeconds % 60;

        timerText.GetComponent<Text>().text = displaySeconds.ToString();

    }

    
}
