using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderObj : MonoBehaviour {
	//[SerializeField] GameObject PanelObj;
	Animator anim;
	[SerializeField] GameObject Collider_Obj;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator TEST(){
		yield return new WaitForSeconds (5);
		Destroy (Collider_Obj);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			anim.Play ("obj_main");
			StartCoroutine (TEST ());
		}
	}


}

