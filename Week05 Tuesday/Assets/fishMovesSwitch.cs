using UnityEngine;
using System.Collections;

public class fishMovesSwitch : MonoBehaviour {

	// declare state constants
	// an enum is a type of variable that you create to make your states more readable. 
	private enum fishStates {
		WAITING_ON_LURE,
		FOLLOWING_LURE,
		CAUGHT_ON_LURE
	}

	// state variable to determine behavior
	private fishStates state = fishStates.WAITING_ON_LURE;

	private Vector3 positionToSwimTo = Vector3.zero;
	private float fishWanderSpeed = 3; //fish goes slower when it is chillin
	private float minDistanceToGetNewPosition = 0.2f;

	private float fishLureSpeed = 5; // fish goes faster when it sees food
	private Transform lurePosition;

	void Start () {
		lurePosition = null;
		pickNewPosition();
	}

	//————————————————————————————————————————————————————————————————————————————————— Update Loop
	void Update () {
		// the most efficient way of writing this is with a switch statement. 
		// if, else if works just fine though, and is only nominally slower
		switch (state) {
			case fishStates.FOLLOWING_LURE:
				fishFollowActions();
				break;
			case fishStates.CAUGHT_ON_LURE:
				fishCaughtActions();
				break;
			case fishStates.WAITING_ON_LURE:
			default:
				fishWaitingActions();
				break;
		}

	}

	//————————————————————————————————————————————————————————————————————————————————— Triggers
	// Trigger checks to see if lure is close enough to follow
	void OnTriggerEnter(Collider otherCollider) {
		// the lure comes close enough to the fish so it starts following
		state = fishStates.FOLLOWING_LURE;
		lurePosition = otherCollider.transform;
	}
	void OnTriggerExit() {
		state = fishStates.WAITING_ON_LURE;
		lurePosition = null;
		// this next bit is fixing a bug
		transform.rotation = Quaternion.identity; //reset rotation after flopping
		GetComponent<Collider>().enabled = true; // turn off collisions
	}
	// Collision sees if fish catches the lure
	void OnCollisionEnter( Collision collisionData ) {
		state = fishStates.CAUGHT_ON_LURE;
		lurePosition = collisionData.transform;
		GetComponent<Collider>().enabled = false; // turn off collisions
		transform.rotation = Quaternion.EulerAngles( Vector3.right * -90f ); // so the fish hangs down
	}

	//————————————————————————————————————————————————————————————————————————————————— Actions
	void fishWaitingActions() {
		// code to wander around
		transform.LookAt( positionToSwimTo );
		transform.position += transform.forward * Time.deltaTime * fishWanderSpeed;
		if (Vector3.Distance( transform.position, positionToSwimTo ) < minDistanceToGetNewPosition) {
			//if close enough to point, pick a new one
			pickNewPosition();
		}
	}
	void pickNewPosition() {
		//pick a new random position to wander to
		Vector3 tempPosition = transform.position + (Random.insideUnitSphere * 10f);
		tempPosition.y = transform.position.y; // keep the y the same, so the fish doesn't swim up and down
		positionToSwimTo = tempPosition;
	}

	void fishFollowActions() {
		if (lurePosition != null) {
			transform.LookAt( lurePosition );
			transform.position += transform.forward * Time.deltaTime * fishLureSpeed;
		}
	}

	void fishCaughtActions() {
		transform.position = lurePosition.position;
	}

}
