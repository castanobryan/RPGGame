using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarAnimate : MonoBehaviour
{
	public Animator anim;
	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{

	}


	void OnTriggerEnter2D (Collider2D other){
			anim.Play ("load_bar_1", -1, 0.0f);
	}
}

