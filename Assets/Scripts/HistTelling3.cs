﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HistTelling3 : MonoBehaviour{

	public GameObject TextoPanel;
	public GameObject Next;
	public GameObject Prev;
	public GameObject Trigger;
	public GameObject Draw;

	// Use this for initialization
	void Start ()
	{
		Draw.SetActive (false);
		TextoPanel.SetActive (false);
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
		Prev.SetActive (true);

	}

	public void ClickNext3(){

		Trigger.transform.position = new Vector2 (122f ,0.55f);
		Next.SetActive (false);
		Prev.SetActive (false);
		TextoPanel.SetActive (false);
		Draw.SetActive (false);
	}

	public void ClickPrev3(){
		Trigger.transform.position = new Vector2 (118f ,0.55f);
		Next.SetActive (false);
		Prev.SetActive (false);
		Draw.SetActive (false);
		TextoPanel.SetActive (false);
	}

}
