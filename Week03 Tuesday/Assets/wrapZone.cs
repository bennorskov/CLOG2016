using UnityEngine;
using System.Collections;

public class wrapZone: MonoBehaviour {
	// note: this script isn't being used at the moment in my example scene

	// move the transform from the collider exiting the trigger 40 units up
	// then reset it's velocity so it starts falling naturally from 0 speed
	void OnTriggerExit( Collider otherObj ) {
		otherObj.transform.position = otherObj.transform.position + Vector3.up * 40;
		otherObj.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
		Debug.Log("thing moving out of the box");
	}
}
