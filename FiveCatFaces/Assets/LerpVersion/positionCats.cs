using UnityEngine;
using System.Collections;

public class positionCats : MonoBehaviour {

	Transform[] cats;
	int numCats = 10;
	float rotateTo;
	public float rotationSpeed = 1f;

	void Start () {
		cats = GetComponentsInChildren<Transform>();
		// This code positions the cat heads dynamically and equally spaced. 
		numCats = cats.Length-1; //Length - 1 because it grabs the transform of this object as well
		float rotationOffset = Mathf.PI * 2 / numCats;
		//2*PI is 360º. / numCats is the space between each one.
		float distance = 3f; // distance from center of the object. 
		for (int i = 0; i<cats.Length; i++) {
			if (cats[i].gameObject.name != "Holder") {
				//this object is named Holder, so skip its Transform
				cats[i].localPosition = new Vector3( Mathf.Cos(rotationOffset*i + Mathf.PI/2) * distance, Mathf.Sin(rotationOffset*i + Mathf.PI/2) * distance, 0);
				// # around the circle determined by i in for loop
				// + PI/2 (90º) to start with one on top
				cats[i].GetComponent<clickCatAlternate>().catID = numCats-i; 
				//using numCats - i because the rotations get setup oposite the order in which the cats are displayed
			}
		}
	}
	
	void Update () {
		//these next few lines are to fix the 360 -> 0 flip. 
		float rotateFrom = transform.rotation.eulerAngles.z;
		float rotateToFix = rotateTo; //this helps with the 360 -> 0 flip
		if (rotateTo - transform.rotation.eulerAngles.z > 180) {
			rotateToFix = rotateTo - 360;
			//if the face is on the left side and needs to rotate the parent left, but is beyond 360
		}
		if (rotateFrom - rotateTo > 180) {
			rotateFrom -= 360;
			//if the face is on the right side and needs to rotate the parent right but is beyond 360
		}
		
		//Use a Lerp to go to the correct rotation
		transform.rotation = Quaternion.Euler ( new Vector3( 0,0, Mathf.Lerp(rotateFrom, rotateToFix, Time.deltaTime*rotationSpeed)));
	}

	public void rotate(int _catID) {
		rotateTo = 360/numCats * _catID;
		//360 is total
		//divided by numCats is the space between each cat face.
		//multiplied by the id of the cat's face in order to get the rotation to rotate towards.
	}
}
