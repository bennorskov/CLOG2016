using UnityEngine;
using System.Collections;

public class moveWithForce : MonoBehaviour {

	float acceleration = 30;
	Rigidbody thisRigidBody;

	// Use this for initialization
	void Start () {
		thisRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		thisRigidBody.AddForce( Vector3.right * Input.GetAxis( "Horizontal" ) * acceleration );
		thisRigidBody.AddForce( Vector3.up * Input.GetAxis("Vertical") * acceleration );
//		GetComponent<Rigidbody>().AddForce( Vector3.right * Input.GetAxis( "Horizontal" ) * acceleration );
	}
}
