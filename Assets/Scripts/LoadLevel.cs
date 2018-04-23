using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

void OnTriggerEnter2D(Collider2D other) {
		SceneManager.LoadScene("1",LoadSceneMode.Single);
	}
}