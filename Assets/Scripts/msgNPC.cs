using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class msgNPC : MonoBehaviour {

	[SerializeField] GameObject msgPanel;
	[SerializeField] GameObject Barrera;
	[SerializeField] GameObject Collider;
	[SerializeField] GameObject BotonAtras;
	[SerializeField] GameObject BotonSiguiente;
	[SerializeField] GameObject BotonObjective;
	[SerializeField] GameObject PanelObjective;
 	[SerializeField] GameObject Prota;
	[SerializeField] GameObject Diosa;
	[SerializeField] GameObject Unknown;
	[SerializeField] GameObject PanelClosed;
	[SerializeField] Text Texto;



	int index = 0;
	public string[] msg;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public string GetMsg(){
			return msg [index];
	}

	/*Worked on it for like 1 week it doesn't work well ;-;
	IEnumerator LetterbyLetter(string txt){
		int letra = 0;
		while (letra < txt.Length) {
			Texto.text += txt [letra];
			letra += 1;
			yield return new WaitForSeconds (0.03f);
		}
	}
*/


	public void Next(){
		//StartCoroutine (LetterbyLetter(GetMsg()));
		index++;
		BotonAtras.SetActive (true);
		Texto.alignment = TextAnchor.UpperLeft;
		if (index == 1) {

			Prota.SetActive (true);
			Unknown.SetActive (false);
			Texto.alignment = TextAnchor.UpperRight;
		} else if (index == 2 || index == 4 || index == 5 || index == 6 || index == 7 || index == 8 || index == 10 || index == 11 || index == 13 || index == 15 || index == 16 || index == 18 || index == 20 || index == 21 || index == 23 || index == 24) {
			Prota.SetActive (false);
			Diosa.SetActive (true);
			Texto.alignment = TextAnchor.UpperLeft;
		} else if (index == 3 || index == 9 || index == 12 || index == 14 || index == 17 || index == 19 || index == 22) {
			Prota.SetActive (true);
			Diosa.SetActive (false);
			Texto.alignment = TextAnchor.UpperRight;
		}

		if (index == 25) {
			BotonSiguiente.SetActive (false);
			BotonObjective.SetActive (true);
			Prota.SetActive (true);
			Diosa.SetActive (false);
			Texto.alignment = TextAnchor.UpperRight;
		}

		if (index == 26) {
			Destroy (Barrera);
			Destroy (Collider);
			Destroy (msgPanel);
			Destroy (BotonAtras);
			Destroy (PanelClosed);




		}
	}
		

	public void Preview(){
		index--;
		if (index == 0) {
			Prota.SetActive (false);
			Unknown.SetActive (true);
			Texto.alignment = TextAnchor.UpperLeft;
		}
		if (index == 1) {
			Prota.SetActive (true);
			Unknown.SetActive (false);
			Diosa.SetActive (false);
			Texto.alignment = TextAnchor.UpperRight;
		} else if (index == 2 || index == 4 || index == 5 || index == 6 || index == 7 || index == 8 || index == 10 || index == 11 || index == 13 || index == 15 || index == 16 || index == 18 || index == 20 || index == 21 || index == 23) {
			Prota.SetActive (false);
			Diosa.SetActive (true);
			Texto.alignment = TextAnchor.UpperLeft;
		} else if (index == 3 || index == 9 || index == 12 || index == 14 || index == 17 || index == 19 || index == 22 || index == 25) {
			Prota.SetActive (true);
			Diosa.SetActive (false);
			Texto.alignment = TextAnchor.UpperRight;
		} 

		if (index == 24) {
			BotonObjective.SetActive (false);
			BotonSiguiente.SetActive (true);
			Prota.SetActive (false);
			Diosa.SetActive (true);
			Texto.alignment = TextAnchor.UpperLeft;
		}
		if (index > 0) {
			BotonAtras.SetActive (true);
		} else {
			BotonAtras.SetActive (false);
		}


	}
}
