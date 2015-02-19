using UnityEngine;
using System.Collections;

public class MoveHandler : MonoBehaviour {
    public int moveSpeed;
    float maxX = Screen.width/2;
    float minX = -Screen.width/2;
    float maxY = Screen.height/2;
    float minY = -Screen.height/2;
 
    private float randomX;
    private float randomY;
    private int[] validChoices = new int[]{-4,-3,-2,-1,1,2,3,4};
	// Use this for initialization
	void Start () {
        randomX = GetRandom();
        randomY = GetRandom();
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector3(randomX, randomY, 0) * moveSpeed * Time.deltaTime);
        // if object reached any border, revert the appropriate direction
        if (transform.position.x >= maxX || transform.position.x <= minX)
        {
            randomX = -randomX;
        }
        if (transform.position.y >= maxY || transform.position.y <= minY)
        {
            randomY = -randomY;
        }
        // make sure the position is inside the borders
        //transform.position.x = Mathf.Clamp(transform.position.x, minX, maxX);
        //transform.position.y = Mathf.Clamp(transform.position.y, minY, maxY);
	}

    void OnCollisionEnter2D(Collision2D collision) 
    {
        
        if(collision.gameObject.tag.Contains("Hamster"))
        {
            randomX = -randomX;
        }
    }

    
 
    int GetRandom() 
    {
         return validChoices[Random.Range(0, validChoices.Length)];
    }

}
