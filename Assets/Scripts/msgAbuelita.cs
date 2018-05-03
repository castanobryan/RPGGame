using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msgAbuelita : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] GameObject Barrera;
	[SerializeField] GameObject Collider;
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
		if (index == 17) {
			//msgPanel.SetActive (false);
			AudioPlayer.clip = Win;
			AudioPlayer.Play ();
			Destroy (Barrera);
			Destroy (Collider);
			Destroy (msgPanel);

		}

		//} while (index<=27);

	}
}