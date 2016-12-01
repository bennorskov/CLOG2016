using UnityEngine;
using System.Collections;

public class rotateCats : MonoBehaviour {

	int currentPosition = 0; 		// holder's position based on last clicked cat head
	int targetPosition = 0; 		// the position to rotate to
	float rotationSpeed = 100f; 	// how many degrees per second to rotate
	float rotationDirection = 1f; 	// Rotate to the left or to the right?
	float rotationStopTolerance = 2f; // see how close you are to stopping 

	public void doARotation(int catStartPosition, float currentX) {
		if (catStartPosition != currentPosition) { // if you click on the top cat, don't rotate

			currentPosition = -1; // set the current posision to -1 so that it will rotate. 
			targetPosition = catStartPosition; // what cat are we rotating to?

			if (currentX < 0) {
				rotationDirection = -1; // if the cat is on the left, rotate to the right
			} else {
				rotationDirection = 1;  // otherwise, the cat is on the right, so rotate to the left
			}
		}
	}

	void Update() {
		if (targetPosition != currentPosition) { // only rotate if the current position isn't the target
			// rotate the parent
			transform.Rotate(Vector3.forward * rotationSpeed * rotationDirection * Time.deltaTime);

			float targetRotation = targetPosition * 72f; // find the target based on the cat's original posiion

			// if close enough to the cat's position, then stop the rotation
			if ( Mathf.Abs(transform.rotation.eulerAngles.z - targetRotation) < rotationStopTolerance) {
				// set the rotation explicitly to a factor of 72 (360 / 5)
				transform.rotation = Quaternion.Euler( Vector3.forward * targetRotation);
				// store the position [0-4] the parent is rotated to
				currentPosition = targetPosition;
			}
		}
	}
}
