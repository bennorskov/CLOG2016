using UnityEngine;
using System.Collections;

public class fishMoves : MonoBehaviour {

	// declare state constants
	// const is optional, but it tells the computer that the value won't change
	private const int WAITING_ON_LURE = 0;
	private const int FOLLOWING_LURE = 1;
	private const int CAUGHT_ON_LURE = 2;

	// state variable to determine behavior
	private int state = WAITING_ON_LURE;

	private float fishSpeed = 5;

	private Transform lurePosition;

	void Start () {
	}
	
	void Update () {
		// the most efficient way of writing this is with a switch statement. 
		// if, else if works just fine though, and is only nominally slower

		if ( state == WAITING_ON_LURE ) {
			//default state. will swim around 
		} else if ( state == FOLLOWING_LURE) {
			// a lure is within range, swim towards it
			// if (lurePosition != null) 
			transform.LookAt( lurePosition );
			transform.position += transform.forward * Time.deltaTime * fishSpeed;
		} else if ( state == CAUGHT_ON_LURE ) {
			// the fish caught the lure, and is parented to it
			transform.position = lurePosition.position;
		}
	}
	// Trigger checks to see if lure is close enough to follow
	void OnTriggerEnter(Collider otherCollider) {
		// the lure comes close enough to the fish so it starts following
		state = FOLLOWING_LURE;
		lurePosition = otherCollider.transform;
	}
	void OnTriggerExit() {
		state = WAITING_ON_LURE;
	}
	// Collision sees if fish catches the lure
	void OnCollisionEnter( Collision collisionData ) {
		state = CAUGHT_ON_LURE;
		lurePosition = collisionData.transform;
	}

}
