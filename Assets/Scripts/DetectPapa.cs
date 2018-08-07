﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectPapa : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] Text msgText;
	[SerializeField] Button btn;

	GameObject actualNPC;

	// Use this for initialization
	void Start () {
		msgPanel.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.name == "ColliderPapa") {
			actualNPC = other.gameObject;
			string msg = actualNPC.GetComponent<msgPapa> ().GetMsg ();
			msgText.text = msg;
			msgPanel.SetActive (true);
		}

	}

	void OnTriggerExit2D (Collider2D other){
		if (other.name=="ColliderPapa"){
			msgPanel.SetActive (false);

		}

	}

	public void Atras(){
		if (actualNPC) {
			actualNPC.GetComponent<msgPapa> ().ButtonAtras ();
			string msg = actualNPC.GetComponent<msgPapa> ().GetMsg ();
			msgText.text = msg;
		}
	}

	public void Boton(){
		if(actualNPC){
			actualNPC.GetComponent<msgPapa> ().Boton ();
			string msg = actualNPC.GetComponent<msgPapa> ().GetMsg();
			msgText.text = msg;
		}
	}

}
