using UnityEngine;
using System.Collections;

public class trapDoorSwitch : MonoBehaviour {
	float rotationSpeed = -10;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		// if I hit a specific key, open the trap door
		if ( Input.GetKey( KeyCode.T ) ) {
			//if the t key is hit
			print("open trapdoor");
			// rotate z by rotationSpeed (negative to go down)
			transform.Rotate( Vector3.forward * rotationSpeed );
		}
	}
}
