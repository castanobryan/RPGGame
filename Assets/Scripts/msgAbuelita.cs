using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msgAbuelita : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] GameObject Barrera;
	[SerializeField] GameObject Collider;
	[SerializeField] GameObject BotonAtras;
	[SerializeField] GameObject Prota;
	[SerializeField] GameObject Abuelita;
	private AudioSource AudioPlayer;
	public AudioClip Win;

	int index = 0;
	public string[] msg;
	// Use this for initialization
	void Start () {
		AudioPlayer = GetComponent<AudioSource> ();

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
			Abuelita.SetActive (false);
		} else {
			Prota.SetActive (false);
			Abuelita.SetActive (true);
		}

		if (index == 17) {
			//msgPanel.SetActive (false);
			AudioPlayer.clip = Win;
			AudioPlayer.Play ();
			Destroy (Barrera);
			Destroy (Collider);
			Destroy (msgPanel);
			Destroy (BotonAtras);

		}

		//} while (index<=27);

	}

	public void ButtonAtras(){
		index--;

		if (index % 2 == 0) {
			Prota.SetActive (true);
			Abuelita.SetActive (false);
		} else {
			Prota.SetActive (false);
			Abuelita.SetActive (true);
		}

		if (index > 0) {
			BotonAtras.SetActive (true);
		} else {
			BotonAtras.SetActive (false);
		}


	}
}