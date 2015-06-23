using UnityEngine;
using System.Collections;

public class moveSceneObject : MonoBehaviour {

	public float moveSpeed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 move = new Vector2 ( moveSpeed * Time.deltaTime, 0 );
		transform.Translate (move);
	}
}
