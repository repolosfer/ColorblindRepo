using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public SceneRandomizer _randomizer;

    public MainMenu(){
        _randomizer = new SceneRandomizer();
    }

    public void StartGame()
    {
        var scene= _randomizer.GetRandomScene();
        Params.CurrentScene = scene;
        Application.LoadLevel(scene.name);
    }

}
