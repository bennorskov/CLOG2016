using UnityEngine;
using System.Collections;

public class lightTrigger : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	// when something enters the Trigger attached to this gameObject
	void OnTriggerEnter() {
		// get the light attached to this game object
		// turn that light on
		GetComponent<Light>().color = Color.cyan;

	}
	// turn the light off when you leave
	void OnTriggerExit() {
		GetComponent<Light>().color = Color.magenta;
	}
}











