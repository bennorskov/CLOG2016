using UnityEngine;
using System.Collections;

public class planeControls : MonoBehaviour {

	public float speed = 10;
	public float turnSpeed = 15;
	public float yawAmount = 25;

	private Rigidbody rb; // store the RigidBody in a temp variable

	void Start () {
		rb = GetComponent<Rigidbody>(); 
	}
	
	void FixedUpdate () {
		float turnAmount = Input.GetAxis("Horizontal") * turnSpeed; //rotate the plane

		float yaw = Input.GetAxis("Horizontal") * -yawAmount; //tilt the plane based on the amount you're turning

		Vector3 rotationAmount = new Vector3( transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + turnAmount , yaw  ); //build the rotation vector

		transform.rotation = Quaternion.Euler ( rotationAmount ); // apply the rotation

		rb.velocity = transform.forward * speed; //push the plane along the forward axis
	}
}
