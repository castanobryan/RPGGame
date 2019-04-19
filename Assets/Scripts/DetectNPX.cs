using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectNPX : MonoBehaviour {

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
		if (other.name == "ColliderDiosa") {
			actualNPC = other.gameObject;
			string msg = actualNPC.GetComponent<msgNPC> ().GetMsg ();
			msgText.text = msg;
			msgPanel.SetActive (true);
		} else if (other.name == "ColliderMom") {
			actualNPC = other.gameObject;
			string msg = actualNPC.GetComponent<msgMama> ().GetMsg ();
			msgText.text = msg;
			msgPanel.SetActive (true);
		}
		
	}

	void OnTriggerExit2D (Collider2D other){
		if(other.name=="ColliderDiosa"){
			msgPanel.SetActive (false);
		} else if (other.name=="ColliderMom"){
			msgPanel.SetActive (false);

		}

	}

	public void NextDialog(){
		if(actualNPC){
			actualNPC.GetComponent<msgNPC> ().Next ();
			string msg = actualNPC.GetComponent<msgNPC> ().GetMsg();
			msgText.text = msg;
		}
	}

	public void PrevDialog(){
		if (actualNPC) {
			actualNPC.GetComponent<msgNPC> ().Preview ();
			string msg = actualNPC.GetComponent<msgNPC> ().GetMsg ();
			msgText.text = msg;
		}
	}

	public void BotonMama(){
		if(actualNPC){
			actualNPC.GetComponent<msgMama> ().Boton ();
			string msg = actualNPC.GetComponent<msgMama> ().GetMsg();
			msgText.text = msg;
		}
	}
		
}
