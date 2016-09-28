using UnityEngine;
using System.Collections;

public class interpolatorExtreme : MonoBehaviour {

	public Transform pointA;
	public Transform pointB;

	public float percent = 0;

	public float numberOfSeconds = 3;

	// Use this for initialization
	void Start () {
//		pointA = GameObject.Find ("pointA").transform; //this line is optional
	}
	
	// Update is called once per frame
	void Update () {
		// set position for the cube as an interpolation
		transform.position = Vector3.Lerp(pointA.position, pointB.position, percent);

		//percent = percent + 1/60f;
		// Time.deltaTime is the amount of change between this frame and the last one
		percent = percent + Time.deltaTime / numberOfSeconds;
		if (percent > 1) {
			percent = 0;
		}

		GetComponent<Renderer> ().material.color = Color.Lerp (Color.red, Color.blue, percent);
	}
}
