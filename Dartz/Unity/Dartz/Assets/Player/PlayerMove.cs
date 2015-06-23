using UnityEngine;
using System.Collections;

public class PlayerMove: MonoBehaviour {

	public Vector2 moveSpeed;
	public Camera cam;
	public Vector2 halfDim;

	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 ();
		Vector3 screenSize = new Vector3 (Screen.width, Screen.height, 0);
		Vector3 screenPos = cam.WorldToScreenPoint (transform.position);
		
		if (Input.GetAxisRaw ("Horizontal") != 0) {
		if (( (screenPos.x - halfDim.x) > screenSize.x / 2 && Input.GetAxisRaw ("Horizontal") < 0) ||
			( (screenPos.x + halfDim.x) < screenSize.x && Input.GetAxisRaw ("Horizontal") > 0)) {
				move.x = moveSpeed.x * Input.GetAxisRaw ("Horizontal") * Time.deltaTime;
			}
		}
		if (Input.GetAxisRaw ("Vertical") != 0) {
			if (( (screenPos.y + halfDim.y) < screenSize.y && Input.GetAxisRaw ("Vertical") > 0) ||
				( (screenPos.y - halfDim.y) > 0 && Input.GetAxisRaw ("Vertical") < 0)) {
				move.y = moveSpeed.y * Input.GetAxisRaw ("Vertical") * Time.deltaTime;
			}
		}
		transform.Translate (move);
	}
}
