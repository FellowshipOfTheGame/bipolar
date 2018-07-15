using UnityEngine;
using System.Collections;

public class PhaseSelector : MonoBehaviour {
	public GameObject[] fases;
	public GameObject loadingImage;
	public static int playable = 1;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < playable; i++) {
			fases [i].SetActive (true);
		}
	}
	public void LoadScene(int level)
	{
		loadingImage.SetActive(true);
		Application.LoadLevel(level);
	}


}
