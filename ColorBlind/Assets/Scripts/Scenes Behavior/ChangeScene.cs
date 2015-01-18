using UnityEngine;
using System.Collections;
using System.Linq;

public class ChangeScene : MonoBehaviour {

    public SceneRandomizer _randomizer;

    public ChangeScene() {
        _randomizer = new SceneRandomizer();
    }

    public void ChangeLevel(){

        Debug.Log(Params.sceneTime.ToString());

        if(Params.levelsPlayed == Params.difficultyChange) {
            Params.sceneIds.Clear();
            Params.levelsPlayed = 0;
            Params.sceneTime--;
            Application.LoadLevel("VeryDificulty");
            return;
        }

        var scene = _randomizer.GetRandomScene();

        while (Params.sceneIds.Any(x => x.Equals(scene.Id))) {
            scene = _randomizer.GetRandomScene();
        }

        Debug.Log(scene.name);
        Params.sceneIds.Add(scene.Id);
        Params.levelsPlayed++;
        Application.LoadLevel(scene.name);
        
    }
}
