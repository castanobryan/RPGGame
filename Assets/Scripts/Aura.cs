using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aura : MonoBehaviour {

	// Tiempo de precarga
	public float waitBeforePlay;

	Animator anim;
	Coroutine manager;
	bool loaded;

	void Start () {
		anim = GetComponent<Animator>();
	}

	public void AuraStart() {
		manager = StartCoroutine(Manager());
		anim.Play("aura_idle");
	}

	public void AuraStop() {
		StopCoroutine(manager);
		anim.Play("aura_idle");
		loaded = false;
	}

	// Método para comprobar si ya hemos cargado suficiente
	public IEnumerator Manager() {
		yield return new WaitForSeconds(waitBeforePlay);
		anim.Play("aura_play");
		loaded = true;
	}

	// Método para comprobar si ya hemos cargado suficiente
	public bool IsLoaded() {
		return loaded;
	}
}