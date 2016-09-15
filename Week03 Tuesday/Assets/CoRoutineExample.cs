using UnityEngine;
using System.Collections;

public class CoRoutineExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("wait2Seconds");
		Debug.Log("print 2");
	}
	IEnumerator wait2Seconds() {
		Debug.Log("print 1");
		yield return new WaitForSeconds( 2 );
		Debug.Log("print 3");
		yield return new WaitForSeconds(2);
		Debug.Log("Print 4");
	}
}
