using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SceneRandomizer {
    
    List<Scene> SceneList;
    private int _sceneCount=3;

    public SceneRandomizer() {
        this.SceneList = new List<Scene>() {
            new Scene(){ Id=1, name="BeetleScene"},
            new Scene(){ Id=2, name= "GameScene2"},
            new Scene(){ Id=3, name= "GameScene3"}
        };

        //for (int i = 1; i <= _sceneCount; i++) {
        //    var scene = new Scene() { Id = i, name = "GameScene" + i };
        //    this.SceneList.Add(scene);
        //}
    }

    public Scene GetRandomScene() {
        var random = Random.Range(1, _sceneCount+1);
        var sceneToLaunch = this.SceneList.FirstOrDefault(x => x.Id.Equals(random));
        return sceneToLaunch;
    }

	
}
