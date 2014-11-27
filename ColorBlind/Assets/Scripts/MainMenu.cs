using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {


    public void StartGame()
    {
        Debug.Log("testStart");
        Application.LoadLevel("TestScene1");
    }

    public void StartTutorial() 
    {
        Debug.Log("testTutorial");
        Application.LoadLevel("Tutorial");
    }
}
