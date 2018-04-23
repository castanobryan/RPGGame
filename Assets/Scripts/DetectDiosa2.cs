using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectDiosa2 : MonoBehaviour {

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
		if (other.name == "ColliderDiosa2") {
			actualNPC = other.gameObject;
			string msg = actualNPC.GetComponent<msgDiosa2> ().GetMsg ();
			msgText.text = msg;
			msgPanel.SetActive (true);
		}

	}

	void OnTriggerExit2D (Collider2D other){
		if (other.name=="ColliderDiosa2"){
			msgPanel.SetActive (false);

		}

	}

	public void Boton(){
		if(actualNPC){
			actualNPC.GetComponent<msgDiosa2> ().Boton ();
			string msg = actualNPC.GetComponent<msgDiosa2> ().GetMsg();
			msgText.text = msg;
		}
	}

}
