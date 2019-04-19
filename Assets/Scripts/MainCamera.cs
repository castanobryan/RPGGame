using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

	public float smoothTime = 3f;

	Transform target;
	float tLX, tLY, bRX, bRY;

	void Awake () { 
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void Update () {
		transform.position = new Vector3(
			Mathf.Clamp(target.position.x,tLX+2,bRX-2),
			Mathf.Clamp(target.position.y,bRY,tLY),
			transform.position.z
		);
			
	}

	public void SetBound (GameObject map) {
		Tiled2Unity.TiledMap config = map.GetComponent<Tiled2Unity.TiledMap>();
		float cameraSize = Camera.main.orthographicSize;

		tLX = map.transform.position.x + cameraSize;
		tLY = map.transform.position.y - cameraSize;
		bRX = map.transform.position.x + config.NumTilesWide - cameraSize;
		bRY = map.transform.position.y - config.NumTilesHigh + cameraSize;

	}

}