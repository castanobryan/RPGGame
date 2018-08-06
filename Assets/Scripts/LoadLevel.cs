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
}

