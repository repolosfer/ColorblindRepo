using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Params : MonoBehaviour {

    public static int difficulty;
    public static List<int> sceneIds;
    public static int levelsPlayed;
    public static int difficultyChange;
    public static int score;
    public static string texturePath = "Graphics/Textures";
    public static int HamstersToWin = 6;
    public static int TimeRemaining;
    public static int Lives = 3;
    public static Scene CurrentScene { get; set; }

    public void Awake()
    {
        Params.sceneIds = new List<int>();
        score = 0;
        levelsPlayed = 0;
        difficultyChange = 3;
        DontDestroyOnLoad(gameObject);
        difficulty = 0;
    }



    
}
