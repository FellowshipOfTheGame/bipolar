﻿using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void Exit(){
		Application.Quit (); 
	}

	void Play(){
		Application.LoadLevel ("Ufo");
	}

	void Comment(){
		Application.LoadLevel ("Comment");
	}

}