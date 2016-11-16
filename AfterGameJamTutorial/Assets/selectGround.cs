using UnityEngine;
using System.Collections;

public class selectGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		Debug.Log( GameObject.FindGameObjectsWithTag("groundFence")[0].name );
//		Debug.Log( GameObject.FindGameObjectsWithTag("groundFence")[1].name );

		GameObject[] groundFences = GameObject.FindGameObjectsWithTag("groundFence");
		foreach( GameObject gFence in groundFences) {
			gFence.transform.Translate(Vector3.up * 2f);
		}

		// below is functionally the same as the above lines, but longer
//		for( int i = 0; i < groundFences.Length; i++ ) {
//			groundFences[i].transform.Translate(Vector3.up * 2f);
//		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
