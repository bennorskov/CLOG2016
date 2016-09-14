using UnityEngine;
using System.Collections;

public class spawnTractor : MonoBehaviour {

	public GameObject tractor;

	void Update () {
		if (Input.GetKeyDown( KeyCode.T ) ) {
			// Spawn a prefab at the position of this game object
			Instantiate( tractor, transform.position, transform.rotation );
		}

		if (Input.GetKeyDown( KeyCode.P ) ) {
			// Spawn a prefab at this gameObject's location, store it in a temporary variable, then add a force to it's rigidbody
			GameObject temp = Instantiate( tractor, transform.position, transform.rotation ) as GameObject;
			temp.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
		}
	}
}
