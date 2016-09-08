using UnityEngine;
using System.Collections;

public class turnThingsBlue : MonoBehaviour {

//	This function is like OnTriggerEnter, except only for collisions
	void OnCollisionEnter( Collision collisionInfo ) {
		// collisionInfo is an object that holds information about the collision that happened between the two objects.
		if (collisionInfo.gameObject.name == "ball") { // if the other object is named ball
			// change it's color to blue
			collisionInfo.gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
	}

}
