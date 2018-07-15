using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    
    public Rigidbody2D wallL;
    public Rigidbody2D wallR;
    public float speed;
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveH = Input.GetAxis("Horizontal");
        if (moveH == 0)
        {
            wallL.AddForce(-0.5f * wallL.velocity * speed);
        } 
        else
        {
            wallL.AddForce(new Vector2(speed * moveH, 0));
        }
    }
}
