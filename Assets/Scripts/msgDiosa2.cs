﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class msgDiosa2 : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] GameObject Barrera;
	[SerializeField] GameObject Collider;
	[SerializeField] GameObject BotonAtras;
	[SerializeField] GameObject Prota;
	[SerializeField] GameObject Diosa;
	[SerializeField] Text Texto;

	int index = 0;
	public string[] msg;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public string GetMsg(){
		return msg [index];
	}

	public void Boton(){
		//do {
		index++;
		BotonAtras.SetActive(true);
		Texto.alignment = TextAnchor.UpperLeft;

		if (index == 1) {
			Prota.SetActive (true);
			Diosa.SetActive (false);
			Texto.alignment = TextAnchor.UpperRight;
		}
		if (index == 2) {
			//msgPanel.SetActive (false);
			Destroy (Barrera);
			Destroy (Collider);
			Destroy (msgPanel);
			Destroy (BotonAtras);

		}

		//} while (index<=27);

	}

	public void ButtonAtras(){
		index--;
		Texto.alignment = TextAnchor.UpperLeft;

		if (index == 0) {
			Prota.SetActive (false);
			Diosa.SetActive (true);
			Texto.alignment = TextAnchor.UpperLeft;
		}else if (index == 1) {
			Prota.SetActive (true);
			Diosa.SetActive (false);
			Texto.alignment = TextAnchor.UpperRight;
		}

		if (index > 0) {
			BotonAtras.SetActive (true);
		} else {
			BotonAtras.SetActive (false);
		}


	}
}