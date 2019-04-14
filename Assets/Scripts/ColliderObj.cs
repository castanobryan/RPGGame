using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderObj : MonoBehaviour {
	//[SerializeField] GameObject PanelObj;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		
		anim.Play ("obj_main");

		//PanelObj.SetActive (true);
	}

	/*void OnTriggerExit2D(Collider2D other){
		anim.SetBool ("Active", false);
	}*/
}

