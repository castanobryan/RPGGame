using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	[Tooltip("Velocidad de movimiento en unidades del mundo")]
	public float speed;

	GameObject player;   // Recuperamos al objeto jugador
	Rigidbody2D rb2d;    // Recuperamos el componente de cuerpo rígido
	Vector3 target, dir; // Vectores para almacenar el objetivo y su dirección
	//public AudioClip PlayerHit;
	//private AudioSource AudioPlayer;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		rb2d = GetComponent<Rigidbody2D>();
		//AudioPlayer = GetComponent<AudioSource> ();

		// Recuperamos posición del jugador y la dirección normalizada
		if (player != null){
			target = player.transform.position;
			dir = (target - transform.position).normalized;
		}
	}

	void FixedUpdate () {
		// Si hay un objetivo movemos la roca hacia su posición
		if (target != Vector3.zero) {
			rb2d.MovePosition(transform.position + (dir * speed) * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		// Si chocamos contra el jugador o un ataque la borramos
		if (col.transform.tag == "Player" || col.transform.tag == "Attack"){
			Destroy(gameObject); 
			//AudioPlayer.clip = PlayerHit;
			//AudioPlayer.Play ();
		}
	}

	void OnBecameInvisible() {
		// Si se sale de la pantalla borramos la roca
		Destroy(gameObject);
	}
}