using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class closedscript : MonoBehaviour {

	Animator anim;
	private string[] hint = new string[3];
	int index = 0;
	[SerializeField] Text hintText;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		hint [0] = "\"A lo mejor olvidé hacer algo\"";
		hint [1] = "\"Parece que todavia no puedo ir por aquí\"";
		hint [2] = "\"Literal... el camino aun esta cerrado\"";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			index = Random.Range (0, 3);
			if (index == 0) {
				hintText.text = hint [0];
			} else if (index == 1) {
				hintText.text = hint [1];
			} else if (index == 2) {
				hintText.text = hint [2];
			}
			anim.Play ("closed_show");
		}
	}

	void OnTriggerExit2D(Collider2D other){
		anim.Play ("closed_hide");
	}
}
