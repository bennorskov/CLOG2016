using UnityEngine;
using System.Collections;

public class drawRay : MonoBehaviour {

	void Update() {
		RaycastHit hitNFO;

		if (Physics.Raycast(transform.position, transform.forward, out hitNFO, 10)) {
			print("distance is: " + hitNFO.distance);
			hitNFO.transform.GetComponent<Renderer>().material.color = Color.green;
		}
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.green;
		Gizmos.DrawRay(transform.position, transform.forward * 10);
	}
}
