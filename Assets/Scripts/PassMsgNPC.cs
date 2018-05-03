using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassMsgNPC : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] Text msgText;
	// Use this for initialization
	void Start () {
		msgPanel.SetActive (false);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "ColliderPass") {
			string msg = other.GetComponent<msgPassNPC> ().GetMsg();
			msgText.text = msg;
			msgPanel.SetActive (true);
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.name == "ColliderPass") {
			msgPanel.SetActive (false);
		}
	}
		
}
