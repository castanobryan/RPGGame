using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (Cinematic2Menu ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Cinematic2Menu(){
		yield return new WaitForSeconds (38);
		SceneManager.LoadScene("mAin",LoadSceneMode.Single);
	}
}
