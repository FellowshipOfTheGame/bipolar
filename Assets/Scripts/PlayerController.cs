using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour {
	private Rigidbody2D rb2d;
	//public string deathText;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	//	deathText = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("Death Zone")){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
			rb2d.isKinematic = true;
		}
		if (other.gameObject.CompareTag ("Portal")) {
			//arranjar um jeito de ir carregando a fase seguinte
			if (SceneManager.GetActiveScene().name == "Level16") {
				SceneManager.LoadScene ("Credits");
			} else {
				if (SceneManager.GetActiveScene().buildIndex + 1 > PhaseSelector.playable)
					PhaseSelector.playable++;
				SceneManager.LoadScene ("Selection");
			}
		}


	}
}
