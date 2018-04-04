﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Area : MonoBehaviour {

	Animator anim;

	void Start (){
		anim = GetComponent<Animator>();
	}

	public IEnumerator ShowArea(string name) {
		anim.Play("text_area_show");
		transform.GetChild(0).GetComponent<Text>().text = name;
		transform.GetChild(1).GetComponent<Text>().text = name;
		yield return new WaitForSeconds(1f);
		anim.Play("text_area_fadeout");
	}
}