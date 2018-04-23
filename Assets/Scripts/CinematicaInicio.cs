using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicaInicio : MonoBehaviour {

	public GameObject Texto1;
	//public GameObject Texto2;


	// Use this for initialization
	void Start () {
		Texto1.SetActive (false);
		//Texto2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D (Collider2D other){
		//Texto2.SetActive (false);
		Texto1.SetActive (true);
	}


	void OnTriggerExit2D (Collider2D other){
		Destroy (Texto1);
	}

}
