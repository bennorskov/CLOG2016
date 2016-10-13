using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class loveHandler : MonoBehaviour {

	Text scoreText;
	int totalLoveAdded = 0;

	void Start () {
		scoreText = GetComponent<Text>();
		scoreText.text = "Total Love: 0";
	}
	
	public void addToTotalLove( int thisMuchMoreLove) {
		totalLoveAdded += thisMuchMoreLove;
		scoreText.text = "Total Love: " + totalLoveAdded;
	}
}
