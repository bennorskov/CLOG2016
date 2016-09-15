using UnityEngine;
using System.Collections;

public class shipShoot : MonoBehaviour {

	public GameObject bullet;
	private bool canFire = true;
	public float rateOfFire = .4f;

	float shipSpeed = 5;

	void Update () {
		if (Input.GetKey(KeyCode.Space) && canFire == true ) {
			canFire = false; // disallow shooting
			StartCoroutine("reload"); // reload gun after rateOfFire seconds
			GameObject temp = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
			temp.GetComponent<Rigidbody>().AddForce(temp.transform.up * 1000);
		}

		//Ship Movement
		float xPos = Input.GetAxis("Horizontal") * Time.deltaTime * shipSpeed;
		transform.position = new Vector3(transform.position.x + xPos, transform.position.y, transform.position.z);

	}

	IEnumerator reload() {
		yield return new WaitForSeconds( rateOfFire );
		canFire = true;
	}
}
