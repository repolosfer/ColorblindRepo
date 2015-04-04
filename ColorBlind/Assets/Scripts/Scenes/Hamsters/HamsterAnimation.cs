using UnityEngine;
using System.Collections;

public class HamsterAnimation : MonoBehaviour {

    ChangeScene _changeScene;
	// Use this for initialization
	void Start () {
        _changeScene = (ChangeScene)ScriptableObject.CreateInstance("ChangeScene");
        _changeScene.isComingDeath = true;
    }
	
	// Update is called once per frame
	void Update () {
   
	}

    public void FinishDeath()
    {
        _changeScene.ChangeToLives();
    }

    public void ChangeLevel()
    {
        _changeScene.isComingDeath = false;
        _changeScene.ChangeLevel();
    }
}
