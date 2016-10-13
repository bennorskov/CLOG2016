using UnityEngine;
using System.Collections;

public class addLove : MonoBehaviour {

	loveHandler lvHand;
	public int howMuchLoveYouHave = 5;
	ParticleSystem heartShooter;

	void Start() {
		lvHand = GameObject.Find("Love Counter").GetComponent<loveHandler>();
		heartShooter = GetComponentInChildren<ParticleSystem>();
		print(heartShooter);
	}

	public void giveLoveToCounter() {
		lvHand.addToTotalLove( howMuchLoveYouHave );
		heartShooter.Play();
	}
}
