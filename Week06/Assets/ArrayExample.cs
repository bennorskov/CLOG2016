using UnityEngine;
using System.Collections;

public class ArrayExample : MonoBehaviour {

	public GameObject[] thingsToSpawn;

	int testInt;

	int[] street = new int[10];

	// Use this for initialization
	void Start () {
		print(testInt);
		testInt = 10;
		print("testInt is " + testInt);

		print(street[0]);
		street[0] = 490;
		print( street.Length );

		thingsToSpawn[0].transform.Translate( Vector3.up * 3);

		for( int i = 0 ; i < thingsToSpawn.Length; i = i + 1) {
			thingsToSpawn[i].transform.Translate( Vector3.up * 3);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
