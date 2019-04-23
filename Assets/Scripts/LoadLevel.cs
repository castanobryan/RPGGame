using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

void OnTriggerEnter2D(Collider2D other) {
		SceneManager.LoadScene("1",LoadSceneMode.Single);
	}

	public void BotonOmitir (){
		SceneManager.LoadScene("1",LoadSceneMode.Single);
	}

	public void Jugar(){
		SceneManager.LoadScene("CinematicInitial",LoadSceneMode.Single);
	}

	public void Controles(){
		SceneManager.LoadScene("Controls",LoadSceneMode.Single);
	}

	public void Creditos(){
		SceneManager.LoadScene("Credits",LoadSceneMode.Single);
	}
		

	public void Volver(){
		SceneManager.LoadScene ("mAin", LoadSceneMode.Single);
	}

	public void Salir (){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}

