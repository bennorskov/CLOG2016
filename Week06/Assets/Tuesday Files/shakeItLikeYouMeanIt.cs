using UnityEngine;
using System.Collections;

public class shakeItLikeYouMeanIt : MonoBehaviour {

	Vector3 origLocation;
	Quaternion origRotation;

	public float numSecondsToShake = 2f;
	public float intensity = 4f;

	// Use this for initialization
	void Start () {
		origLocation = transform.position;
		origRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.S)) {
			StartCoroutine("shakeCam");
		}
	}

	IEnumerator shakeCam() {
		// shake for a number of seconds
		float timeLeft = numSecondsToShake;
		while (timeLeft > 0) {
//			transform.LookAt(GameObject.Find("Cylinder").transform.position);
			transform.position = origLocation + Random.insideUnitSphere * intensity;
			timeLeft -= Time.deltaTime;
			yield return null; // stops the loop from contining this time
		}
		// return the camera to the orig position
		transform.position = origLocation;
		transform.rotation = origRotation;
	}
}
