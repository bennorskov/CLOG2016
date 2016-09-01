using UnityEngine;
using System.Collections;

public class playAudio : MonoBehaviour {

	void OnTriggerEnter() {
		GetComponent<AudioSource>().Play();
	}
}
