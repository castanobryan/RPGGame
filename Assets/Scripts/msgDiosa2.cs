using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msgDiosa2 : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] GameObject Barrera;
	[SerializeField] GameObject Collider;
	[SerializeField] GameObject BotonAtras;

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
		if (index > 0) {
			BotonAtras.SetActive (true);
		} else {
			BotonAtras.SetActive (false);
		}


	}
}