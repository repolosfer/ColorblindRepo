using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public SceneRandomizer _randomizer;

    public MainMenu(){
        _randomizer = new SceneRandomizer();
    }

    public void StartGame()
    {
        Debug.Log("testStart");
        var scene= _randomizer.GetRandomScene();
        Debug.Log(scene.name);
        Application.LoadLevel(scene.name);
    }

    public void StartTutorial() 
    {
        Debug.Log("testTutorial");
        Application.LoadLevel("Tutorial");
    }
}
