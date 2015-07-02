using UnityEngine;
using System.Collections;

public class MovieHandler : MonoBehaviour {

    ChangeScene _changeScene;
    public string movieClip;
    public bool IsWin;
	// Use this for initialization
	void Start () {
        _changeScene = (ChangeScene)ScriptableObject.CreateInstance("ChangeScene");
        Handheld.PlayFullScreenMovie(movieClip + ".mp4", Color.black,FullScreenMovieControlMode.Hidden,FullScreenMovieScalingMode.Fill);
        if (IsWin)
        {
            _changeScene.ChangeToScore();
        }
        else
        {
            _changeScene.ChangeToLives();
        }
        
    }
	
}
