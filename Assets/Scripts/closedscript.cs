using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closedscript : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			anim.Play ("closed_show");
		}
	}

	void OnTriggerExit2D(Collider2D other){
		anim.Play ("closed_hide");
	}
}
