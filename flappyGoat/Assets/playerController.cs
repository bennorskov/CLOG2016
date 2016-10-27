using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {
	Rigidbody2D rb;

	public float flapForce = 100;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			rb.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);
		}		
		transform.rotation = Quaternion.Euler( new Vector3(0, 180, -3 * rb.velocity.y));
	}

	void OnCollisionEnter2D( Collision2D nfo) {
		if (nfo.collider.CompareTag("groundFence")) {
			StartCoroutine("deathAni");
		}
	}
	IEnumerator deathAni() {
		rb.velocity = Vector2.zero;
		rb.Sleep();
		rb.gravityScale = 0;
		GetComponent<Collider2D>().enabled = false;
		GetComponent<Renderer>().material.color = Color.red;
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(0);
	}
}
