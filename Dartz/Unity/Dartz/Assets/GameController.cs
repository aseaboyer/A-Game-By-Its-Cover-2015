using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float objectSpeed = 0f;
	public float objectStartSpeed = 10f;
	public float speedIncrement = 0.01f;

	public GameObject dartModel;
	public GameObject[] wallModels;
	public bool makeWallNext; // Toggle this to alternate making walls and darts

	void Awake () {
		objectSpeed = objectStartSpeed;
		spawnDart ();
	}

	void Update () {
		objectSpeed += (speedIncrement * Time.deltaTime); // Steadily Increase Speed
		
	}

	public void spawnDart(){
		Instantiate (dartModel, Vector3.zero, Quaternion.identity);
	}
}
