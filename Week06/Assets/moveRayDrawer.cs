using UnityEngine;
using System.Collections;

public class moveRayDrawer : MonoBehaviour {
	public void turnLeft() {
		transform.Rotate(Vector3.up * 2);
	}
	public void turnRight() {
		transform.Rotate(Vector3.up * -2);
	}
}
