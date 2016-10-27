using UnityEngine;
using System.Collections;

public class leaveBoxScore : MonoBehaviour {

	private scoreHolder sh;
	public float fenceSpeed = 3;

	void Start() {
		sh = GameObject.Find("ScoreHolder").GetComponent<scoreHolder>();
	}

	void Update() {
		transform.Translate(Vector2.left * fenceSpeed * Time.deltaTime);
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.CompareTag("Player")) {
			sh.addPoint();
		}
	}
}
