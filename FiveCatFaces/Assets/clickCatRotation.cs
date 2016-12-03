using UnityEngine;
using System.Collections;

public class clickCatRotation : MonoBehaviour {

	public int position = 0;

	void OnMouseDown () {
		GetComponentInParent<trigRotate>().setTargetRotation(position);
	}
}
