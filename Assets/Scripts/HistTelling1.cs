using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistTelling1 : MonoBehaviour{

	public GameObject TextoPanel;
	public GameObject Next;
	public GameObject Trigger;
	public GameObject Draw;
	//public Animator anim;


	// Use this for initialization
	void Start ()
	{
		TextoPanel.SetActive (false);
		Draw.SetActive (false);

	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerEnter2D (Collider2D other){
		Draw.SetActive (true);
		TextoPanel.SetActive (true);

	}




	void OnTriggerExit2D (Collider2D other){
		Next.SetActive (true);


	}

	public void ClickNext1(){

		Trigger.transform.position = new Vector2 (118f ,0.55f);
		Next.SetActive (false);
		TextoPanel.SetActive (false);
		Draw.SetActive (false);

	}
		
}

