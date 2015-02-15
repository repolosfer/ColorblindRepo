using UnityEngine;
using System.Collections;
using System.Linq;

public class TempSceneChange : MonoBehaviour {

    public SceneRandomizer _randomizer;

    public TempSceneChange()
    {
        _randomizer = new SceneRandomizer();
    }

    public void ChangeLevel()
    {

        Debug.Log(Params.sceneTime.ToString());

        if (Params.levelsPlayed == Params.difficultyChange)
        {
            Debug.Log("changing difficulty");
            Params.sceneIds.Clear();
            Params.levelsPlayed = 0;
            Params.sceneTime--;
            Application.LoadLevel("VeryDificulty");
            return;
        }

        var scene = _randomizer.GetRandomScene();

        while (Params.sceneIds.Any(x => x.Equals(scene.Id)))
        {
            scene = _randomizer.GetRandomScene();
        }

        Debug.Log(scene.name);
        Params.sceneIds.Add(scene.Id);
        Params.levelsPlayed++;
        Application.LoadLevel(scene.name);

    }

    public void Death()
    {
        Application.LoadLevel("FinishScreen");
    }
}
