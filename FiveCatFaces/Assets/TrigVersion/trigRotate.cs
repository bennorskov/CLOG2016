using UnityEngine;
using System.Collections;

public class trigRotate : MonoBehaviour {

	float angle = 0;
	float targetRotation = 0;
	float easing = .1f;
	float offsetAmount;
	float distance = 2.32f;

	public Transform[] childCats;

	void Start() {
		offsetAmount = Mathf.PI * 2 / 5; // Mathf.PI * 2 is 360º. Divide by 5, the number of elements we have
	}

	public void setTargetRotation (int catStartPosition) {
		targetRotation = catStartPosition * offsetAmount;
	}
	
	void Update () {

		// print(targetRotation*Mathf.Rad2Deg + " | " + angle*Mathf.Rad2Deg);

		float nintyOffest = Mathf.PI*.5f;
		angle -= (angle + targetRotation) * easing;
		for(int i = 0; i<childCats.Length; i++) {
			int pos = childCats[i].GetComponent<clickCatRotation>().position;
			float currAngle = pos * offsetAmount;
			float cosAng = Mathf.Cos( currAngle + angle + nintyOffest) * distance;
			float sinAng = Mathf.Sin( currAngle + angle + nintyOffest) * distance;

			childCats[i].position = new Vector2(cosAng, sinAng);
		}
	}
}
