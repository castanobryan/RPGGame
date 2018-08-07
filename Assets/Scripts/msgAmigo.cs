using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msgAmigo : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] GameObject Barrera;
	[SerializeField] GameObject Collider;
	[SerializeField] GameObject NPC;
	[SerializeField] GameObject Anim;
	[SerializeField] GameObject BotonAtras;
	[SerializeField] GameObject Amigo;
	[SerializeField] GameObject Prota;

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

		if (index % 2 == 0) {
			Prota.SetActive (true);
			Amigo.SetActive (false);
		} else {
			Prota.SetActive (false);
			Amigo.SetActive (true);
		}

		if (index == 12) {
			//msgPanel.SetActive (false);
			Destroy (Barrera);
			Destroy (Collider);
			Destroy (msgPanel);
			Destroy (NPC);
			Anim.SetActive (true);

		}

		//} while (index<=27);

	}

	public void ButtonAtras(){
		index--;

		if (index % 2 == 0) {
			Prota.SetActive (true);
			Amigo.SetActive (false);
		} else {
			Prota.SetActive (false);
			Amigo.SetActive (true);
		}

		if (index > 0) {
			BotonAtras.SetActive (true);
		} else {
			BotonAtras.SetActive (false);
		}


	}

}