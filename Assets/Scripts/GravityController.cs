using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour {

    void Start()
    {
        Physics2D.gravity = new Vector3(0, -9.81f, 0);
    }

	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.X))
            Physics2D.gravity *= -1;
	}
}
