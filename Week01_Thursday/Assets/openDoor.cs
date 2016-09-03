using UnityEngine;
using System.Collections;

public class openDoor : MonoBehaviour {

	void OnTriggerEnter() {
		//Access another gameObject called "door" and set it to inactive
		GameObject.Find("door").SetActive(false);
		//play the door open sound. 
		GetComponent<AudioSource>().Play();
	}
}
