using UnityEngine;
using System.Collections;

public class enemyHitDetection : MonoBehaviour {
	void OnTriggerEnter( Collider other) {
		Destroy(other.gameObject); //destroy bullet

		//get score object and add score
		// Note: this is a more complex way of doing this command
		//   usually you'd store the score Tracker in a local variable
		//   and access it in Start, so as to only do it once. 

		GameObject scoreH = GameObject.Find("ScoreHolder");
		scoreH.GetComponent<scoreTracker>().addScore(324);

		Destroy(gameObject); //destroy self
	}
}
