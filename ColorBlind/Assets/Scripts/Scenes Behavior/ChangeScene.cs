using UnityEngine;
using System.Collections;
using System.Linq;

public class ChangeScene : ScriptableObject {

    public SceneRandomizer _randomizer;

    public bool isComingDeath;

    public ChangeScene() {
        _randomizer = new SceneRandomizer();
    }

    public void ChangeLevel() {

        if (!isComingDeath)
        {
            Params.sceneIds.Add(Params.CurrentScene.Id);
            Params.levelsPlayed++;
        }

        Debug.Log(Params.levelsPlayed);

        if (Params.levelsPlayed == Params.difficultyChange)
        {
            Params.sceneIds.Clear();
            Params.levelsPlayed = 0;
            Params.difficulty++;
            Application.LoadLevel("VeryDificulty");
            return;
        }

        var scene = _randomizer.GetRandomScene();

        while (Params.sceneIds.Any(x => x.Equals(scene.Id))) {
            scene = _randomizer.GetRandomScene();
        }

        Params.CurrentScene = scene;
        
        Application.LoadLevel(scene.name);
        
    }

    public void ChangeToLives() {
        Application.LoadLevel("LivesScene");
    }

    public void ChangeToScore()
    {
        Application.LoadLevel("ScoreScene");
    }
}
