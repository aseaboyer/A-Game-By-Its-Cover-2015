using UnityEngine;
using System.Collections;

public class PlayerImpacts : MonoBehaviour {

	public float score = 0f;

	public GameObject eye;
	public float bullseyeMax = 0.15f;
	public GameObject textBullseye;
	public float scoreBullseye = 300f;
	public float greatMax = 0.67f;
	public GameObject textGreat;
	public float scoreGreat = 150f;
	public GameObject textGood;
	public float scoreGood = 50f;

	void OnCollisionEnter2D(Collision2D c) {
		Debug.Log ( "Player hit a " + c.gameObject.tag );
		if( c.gameObject.tag == "Dart" ) {
			ContactPoint2D contactPoint = c.contacts[0];
			Debug.Log ( contactPoint.point );
			float impactDist = Vector2.Distance( contactPoint.point, eye.transform.position );
			Debug.Log ( impactDist );
			if(impactDist <= bullseyeMax) {
				recordImpact( textBullseye, contactPoint.point, scoreBullseye );
			} else if(impactDist <= greatMax) {
				recordImpact( textGreat, contactPoint.point, scoreGreat );
			} else {
				recordImpact( textGood, contactPoint.point, scoreGood );
			}

			Destroy( c.gameObject );
		}
	}

	private void recordImpact( GameObject scoreMarker, Vector2 scorePos, float scoreVal ) {
		Instantiate (scoreMarker, scorePos, Quaternion.identity);
		score += scoreVal;
	}
}
