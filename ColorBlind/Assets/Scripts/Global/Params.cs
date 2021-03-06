﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Params : MonoBehaviour {

    public static int sceneTime = 10;
    public static List<int> sceneIds;
    public static int levelsPlayed;
    public static int difficultyChange;
    public static int score;
    public static string texturePath = "Graphics/Textures";
    public void Awake()
    {
        Params.sceneIds = new List<int>();
        score = 0;
        levelsPlayed = 0;
        difficultyChange = 3;
        DontDestroyOnLoad(gameObject);

    }
}
