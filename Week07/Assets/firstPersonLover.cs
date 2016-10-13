using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class firstPersonLover : MonoBehaviour {
	Image crosshair;

	void Start () {
		crosshair = GameObject.Find("crossHair").GetComponent<Image>();
	}
	
	void Update () {
		crosshair.color = Color.white;
		RaycastHit nfo; //how you get information about what you hit
		if (Physics.Raycast(transform.position, transform.forward, out nfo) == true ) {
			if ( nfo.transform.CompareTag("Friend") == true ) { 
				// nfo.transform.tag == "Friend"
				crosshair.color = Color.red;
				if ( Input.GetMouseButtonDown(0) ) {
					nfo.transform.GetComponent<addLove>().giveLoveToCounter();
				}
			}
		}
	}
}
