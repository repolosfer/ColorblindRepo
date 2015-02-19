using UnityEngine;
using System.Collections;

public class BeetleTouch : MonoBehaviour {

    public bool isLowO2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Descomentar esto para probar en emulador
        if (Input.touchCount == 1)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (collider2D == Physics2D.OverlapPoint(touchPos) && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                if (isLowO2)
                {
                    //TODO: remove scene hardcode
                    //Application.LoadLevel("HamsterSceneWin");
                    
                    this.GetComponent<SpriteRenderer>().sprite = Resources.Load(Params.texturePath +"/Hamsters/HighO2", typeof(Sprite)) as Sprite;
                }
                else
                {
                    //TODO: remove scene hardcode
                    this.GetComponent<SpriteRenderer>().sprite = Resources.Load(Params.texturePath + "/Hamsters/LowO2", typeof(Sprite)) as Sprite;
                }
                isLowO2 = !isLowO2;
            }
        }

	}

    //Comentar esto para probar en emulador
    void OnMouseDown()
    {

        if (isLowO2)
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load(Params.texturePath + "/Hamsters/HighO2", typeof(Sprite)) as Sprite;

        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.Load(Params.texturePath + "/Hamsters/LowO2", typeof(Sprite)) as Sprite;
        }
        isLowO2 = !isLowO2;
    }
}
