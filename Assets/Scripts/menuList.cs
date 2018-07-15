using UnityEngine;
using System.Collections;

public class menuList : MonoBehaviour {
	public GameObject menuLista;
	private float before = -1;
	// Use this for initialization
	void Start () {
	
	}


	public void OnSliderMove(float value){
		if (before == -1 || value>before) {
			menuLista.transform.position+= Vector3.left * (value*10);
			before = value;
		}
		if (value < before) {
			menuLista.transform.position-= Vector3.left * (value*10);
			before = value;
		}

	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
