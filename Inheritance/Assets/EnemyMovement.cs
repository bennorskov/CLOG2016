using UnityEngine;
using System.Collections;

public class EnemyMovement : mover {

	string direction = "right";

	void Start () {
		InvokeRepeating("changeDirection", 1f, 1f);
		base.Start();
		speed = 6;
	}
	
	void Update () {
		if (direction == "left") {
			MoveLeft();
		} 
		if (direction == "right") {
			MoveRight();
		}

		if (Input.GetKeyDown(KeyCode.I)) {
			takeDamage(5);
		}
	}

	void changeDirection() {
		if (direction == "left") {
			direction = "right";
		} else {
			direction = "left";
		}
	}
}
