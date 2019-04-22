using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class msgAbuelita : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] GameObject Barrera;
	[SerializeField] GameObject Collider;
	[SerializeField] GameObject BotonAtras;
	[SerializeField] GameObject BotonPreTrophy;
	[SerializeField] GameObject BotonTrophy;
	[SerializeField] GameObject Prota;
	[SerializeField] GameObject Abuelita;
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
			Abuelita.SetActive (false);
			Texto.alignment = TextAnchor.UpperLeft;
		} else {
			Prota.SetActive (false);
			Abuelita.SetActive (true);
			Texto.alignment = TextAnchor.UpperRight;
		}

		if (index == 16) {
			BotonPreTrophy.SetActive (false);
			BotonTrophy.SetActive (true);
			Abuelita.SetActive (true);
			Prota.SetActive (false);
			Texto.alignment = TextAnchor.UpperRight;
		}

		if (index == 17) {
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
			Abuelita.SetActive (false);
			Texto.alignment = TextAnchor.UpperLeft;
		} else {
			Prota.SetActive (false);
			Abuelita.SetActive (true);
			Texto.alignment = TextAnchor.UpperRight;
		}

		if (index == 15) {
			BotonTrophy.SetActive (false);
			BotonPreTrophy.SetActive (true);
			Abuelita.SetActive (false);
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