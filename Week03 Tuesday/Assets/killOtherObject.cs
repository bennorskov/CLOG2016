using UnityEngine;
using System.Collections;

public class killOtherObject : MonoBehaviour {

	//Use the collider from a collision to destroy the gameobject attached to it. 
	void OnTriggerExit( Collider otherObj ) {
		Destroy(otherObj.gameObject);
	}
}
