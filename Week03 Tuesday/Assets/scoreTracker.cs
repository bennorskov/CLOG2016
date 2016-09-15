using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreTracker : MonoBehaviour {

	int score = 0;
	Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();
		scoreText.text = "Score: " + score;
	}

	public void addScore( int pointsToAdd ) {
		// public function to add in points from any other object
		score = score + pointsToAdd;
		scoreText.text = "Score: " + score;
	}
}
