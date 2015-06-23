using UnityEngine;
using System.Collections;

public class TextScript : MonoBehaviour {

	public float lifeTime = 1f;

	void Awake () {
		Destroy (gameObject, lifeTime);
	}
}
