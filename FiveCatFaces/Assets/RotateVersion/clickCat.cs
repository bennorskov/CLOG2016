using UnityEngine;
using System.Collections;

public class clickCat : MonoBehaviour {

	public int startPos; // store each cat's starting position from 0 - 5

	void Update () {
		// keep the cat's head upright
		transform.rotation = Quaternion.identity;
	}

	void OnMouseDown() {
		// call the rotation script on the parent
		// pass through the id to rotate to that posision
		// pass through the x position to see where it is in rotation
		GetComponentInParent<rotateCats>().doARotation(startPos, transform.position.x);
	}
}
