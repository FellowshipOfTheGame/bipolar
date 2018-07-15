using UnityEngine;
using System.Collections;

public class ColorController : MonoBehaviour {
	public Sprite blues;
	public Sprite reds;

	public GameObject gameObject;
	private bool blue;
    private Renderer r;

    void Start()
    {
		gameObject.GetComponent<SpriteRenderer> ().sprite = blues;
		blue = true;
    }

	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Z))
        {
            blue = !blue;
            if (blue)
            {
				gameObject.GetComponent<SpriteRenderer> ().sprite = blues;
                gameObject.layer = 10;
            }
            else
            {
				gameObject.GetComponent<SpriteRenderer> ().sprite = reds;
                gameObject.layer = 9;
            }
        }
	}
    
}
