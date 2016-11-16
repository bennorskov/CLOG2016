using UnityEngine;
using System.Collections;

public class sphereScript : MonoBehaviour {

	public string saying = "This is from the Sphere";
	string anotherSaying = "This saying is private. You can't access it from outside this script";

	void Start () {
		//intentionally blank
	}
	void Update() {
		//intentionally blank
	}
	// grab the script from the object entering the trigger
	void OnTriggerEnter(Collider otherObj) {
		GameObject c = otherObj.gameObject;
		c.GetComponent<squareScript>().printOutThree();
		// note: this will work only because I know the object coming into the script will have the script "squareScript" attached to it
		// safer programming would be to test the object inside the trigger against a tag, and if it's the right tag
		// grab the squareScript on that object
	}
}
