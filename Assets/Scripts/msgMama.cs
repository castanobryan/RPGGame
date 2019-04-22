using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class msgMama : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] GameObject Barrera;
	[SerializeField] GameObject Collider;
	[SerializeField] GameObject BotonAtras;
	[SerializeField] GameObject BotonPreTrophy;
	[SerializeField] GameObject BotonTrophy;
	[SerializeField] GameObject Mama;
	[SerializeField] GameObject Prota;
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
		BotonAtras.SetActive (true);
		Texto.alignment = TextAnchor.UpperLeft;


		if (index % 2 == 0) {
			Prota.SetActive (true);
			Mama.SetActive (false);
			Texto.alignment = TextAnchor.UpperLeft;
		} else {
			Prota.SetActive (false);
			Mama.SetActive (true);
			Texto.alignment = TextAnchor.UpperRight;
		}

		if (index == 21) {
			BotonPreTrophy.SetActive (false);
			BotonTrophy.SetActive (true);
			Mama.SetActive (true);
			Prota.SetActive (false);
			Texto.alignment = TextAnchor.UpperRight;
		}

		if (index == 22) {
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

		if (index % 2 == 0) {
			Prota.SetActive (true);
			Mama.SetActive (false);
			Texto.alignment = TextAnchor.UpperLeft;
		} else {
			Prota.SetActive (false);
			Mama.SetActive (true);
			Texto.alignment = TextAnchor.UpperRight;
		}

		if (index == 20) {
			BotonTrophy.SetActive (false);
			BotonPreTrophy.SetActive (true);
			Mama.SetActive (false);
			Prota.SetActive (true);
			Texto.alignment = TextAnchor.UpperLeft;
		}

		if (index > 0) {
			BotonAtras.SetActive (true);
		} else {
			BotonAtras.SetActive (false);
		}


	}
}
