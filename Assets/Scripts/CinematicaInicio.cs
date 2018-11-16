using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicaInicio : MonoBehaviour {

	public GameObject Texto1;
	public GameObject Next1;
	public GameObject Prev1;
	public GameObject Entity;



	// Use this for initialization
	void Start () {
		Texto1.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D (Collider2D other){
		

		Texto1.SetActive (true);
	
	}



	void OnTriggerExit2D (Collider2D other){
		
		Next1.SetActive (true);

	}
}
