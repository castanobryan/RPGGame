using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassTalkTam : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] GameObject ColliderTalk1;
	[SerializeField] GameObject ColliderTalk2;
	[SerializeField] Text msgText;
	// Use this for initialization
	void Start () {
		msgPanel.SetActive (false);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "ColliderTalkTam1") {
			string msg = other.GetComponent<msgPassNPC> ().GetMsg ();
			msgText.text = msg;
			msgPanel.SetActive (true);
		} else if (other.name == "ColliderTalkTam2") {
			string msg = other.GetComponent<msgPassNPC> ().GetMsg ();
			msgText.text = msg;
			msgPanel.SetActive (true);
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.name == "ColliderTalkTam1") {
			msgPanel.SetActive (false);
			Destroy (ColliderTalk1);

		} else if (other.name == "ColliderTalkTam2") {
			msgPanel.SetActive (false);
			Destroy (ColliderTalk2);
		}
	}
}
