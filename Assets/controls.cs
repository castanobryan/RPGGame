using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {
	[SerializeField] GameObject Collider_Obj;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator WaitTilEnds(){
		yield return new WaitForSeconds (4);
		Destroy (Collider_Obj);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			anim.Play ("attack_show");
			StartCoroutine (WaitTilEnds ());
		}
	}
}
