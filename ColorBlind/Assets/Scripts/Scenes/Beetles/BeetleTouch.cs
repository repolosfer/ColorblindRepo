using UnityEngine;
using System.Collections;

public class BeetleTouch : MonoBehaviour {

    public bool isWinBeetle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Descomentar esto para probar en emulador
        //if (Input.touchCount == 1) {
        //    Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //    Vector2 touchPos = new Vector2(wp.x, wp.y);
        //    if (collider2D == Physics2D.OverlapPoint(touchPos))
        //    {
        //        Debug.Log("is hitting a beetle");
        //        Debug.Log(gameObject.name);
        //        if (isWinBeetle)
        //        {
        //            //TODO: remove scene hardcode
        //            Application.LoadLevel("GameScene1Win");
        //        }
        //        else
        //        {
        //            //TODO: remove scene hardcode
        //            Application.LoadLevel("GameScene1Death");
        //        }
        //    }
        //}
	}

    //Comentar esto para probar en emulador
    void OnMouseDown()
    {
        if (isWinBeetle)
        {
            //TODO: remove scene hardcode
            Application.LoadLevel("BeetleSceneWin");
        }
        else
        {
            //TODO: remove scene hardcode
            Application.LoadLevel("BeetleSceneDeath");
        }
    }
}
