using UnityEngine;
using System.Collections;

public class squareScript : MonoBehaviour {

	//find a GameObject named "Sphere" and access the script "sphereScript" on it
	//store that instance of the "sphereScript" in a temporary variable named s
	//print out the public variable "saying" on the sphereScript s
	void Start () {
		sphereScript s = GameObject.Find("Sphere").GetComponent<sphereScript>();
		print( s.saying );
	}
	void Update () {
		//intentionally blank
	}

	public void printOutTheNumber5() {
		Debug.Log(4); 
	}
	public void printOutThree() {
		print(3);
	}
	void printOut45() {
		print(45);
		//this function is private
		//only this script can access it
	}
}
