using UnityEngine;
using System.Collections;

public class MoleController : MonoBehaviour {

    public float XForce;
    public float YForce;
    public float directionx;
    public float directiony;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        directionx = Input.acceleration.x * XForce;
        directiony = Input.acceleration.z * YForce;

        rb.AddForce(new Vector3(directionx, -directiony,0));
	}
    

    void FixedUpdate()
    {
        
    }
}
