using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreHolder : MonoBehaviour {
	Text scoreDisplay;
	int score;
	void Start () {
		scoreDisplay = GetComponent<Text>();
		score = 0;
		displayText();
	}
	void displayText() {
		scoreDisplay.text = "Score: " + score;
	}

	public void addPoint() {
		score++;
		displayText();
	}
}
