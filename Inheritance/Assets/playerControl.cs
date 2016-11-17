using UnityEngine;
using System.Collections;

public class playerControl : mover {

	void Start() {
		GetComponent<Renderer>().material.color = Color.red;
		base.Start();
	}

	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			MoveLeft();
		}
		if (Input.GetKey(KeyCode.S)) {
			MoveDown();
		}
		if (Input.GetKey(KeyCode.D)) {
			MoveRight();
		}
		if (Input.GetKey(KeyCode.W)) {
			MoveUp();
		}
	}

	void OnTriggerEnter() {
		takeDamage(1f);
	}
}
