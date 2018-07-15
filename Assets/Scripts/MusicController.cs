using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {

    public Transform mp;

	// Use this for initialization
	void Start () {
	    if (!GameObject.FindGameObjectWithTag("MusicPlayer"))
        {
            Debug.Log("oi2");
            Transform t = GameObject.Instantiate<Transform>(mp);
            GameObject.DontDestroyOnLoad(t);
        }
	}
	
}
