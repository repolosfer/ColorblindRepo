using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {

    private GameObject scoreLbl;
	// Use this for initialization
	void Start () {
        scoreLbl = GameObject.Find("Score");
        IncreaseScore();
        
	}

    private void IncreaseScore()
    {
        scoreLbl.GetComponent<Text>().text = Params.score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
