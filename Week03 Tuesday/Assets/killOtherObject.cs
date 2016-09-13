using UnityEngine;
using System.Collections;

public class killOtherObject : MonoBehaviour {
	int lives = 30;

	void OnTriggerExit( Collider otherObj ) {
		otherObj.transform.position = otherObj.transform.position + Vector3.up * 40;
		otherObj.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
		Debug.Log("thing moving out of the box");
	}
}
