using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 4f;

	Animator anim;
	Rigidbody2D rb2d;
	Vector2 mov;  // Ahora es visible entre los métodos

	void Start () {
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}

	void Update () {

		// Detectamos el movimiento en un vector 2D
		mov = new Vector2(
			Input.GetAxisRaw("Horizontal"),
			Input.GetAxisRaw("Vertical")
		);

		// Establecemos las animaciones
		if (mov != Vector2.zero) {
			anim.SetFloat("movX", mov.x);
			anim.SetFloat("movY", mov.y);
			anim.SetBool("walking", true);
		} else {
			anim.SetBool("walking", false);
		}

	}

	void FixedUpdate () {
		// Nos movemos en el fixed por las físicas
		rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
	}
}