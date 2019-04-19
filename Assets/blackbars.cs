using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackbars : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		anim.Play ("blackbars");
	}

	void OnTriggerExit2D(Collider2D other){
		anim.Play ("blackbars_back");
	}

}
