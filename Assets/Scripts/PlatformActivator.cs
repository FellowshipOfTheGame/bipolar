using UnityEngine;
using System.Collections;

public class PlatformActivator : MonoBehaviour {

	public bool activated;
	private SpriteRenderer sprite;
	private BoxCollider2D box;
	private EdgeCollider2D edge;
	private Color originalColor;
	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer>();
		box = GetComponent<BoxCollider2D>();
		edge = GetComponent<EdgeCollider2D>();
		originalColor = sprite.color;

		if (this.CompareTag("Red")){
			sprite.enabled = true;
			sprite.color = new Color(1f,1f,1f,.15f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Z))
		{
			activated = !activated;
			if (activated)
			{
				sprite.color = originalColor;
				sprite.enabled = true;
				box.enabled = true;
				edge.enabled = true;
			}
			else
			{
				sprite.color = new Color(1f,1f,1f,.15f);
				//sprite.enabled = false;
				box.enabled = false;
				edge.enabled = false;
			}
		}
	}
}
