using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	public float speed;
	public float health;

	public void Start () {
		speed = 10f;
		health = 20f;
	}

	public void MoveUp() {
		transform.Translate(Vector3.up * speed * Time.deltaTime);
	}
	public void MoveDown() {
		transform.Translate(Vector3.down * speed * Time.deltaTime);
	}
	public void MoveLeft() {
		transform.Translate(Vector3.left * speed * Time.deltaTime);
	}
	public void MoveRight() {
		transform.Translate(Vector3.right * speed * Time.deltaTime);
	}

	public void takeDamage(float amountOfDamage) {
		health -= amountOfDamage;
		if (health <= 0) {
			Destroy(gameObject);
		}
	}
}
