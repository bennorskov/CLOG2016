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
		RaycastHit nfo;
		if (Physics.Raycast(transform.position, transform.forward, out nfo) ) {
			if (nfo.transform.CompareTag("Friend")) {
				crosshair.color = Color.red;
				if ( Input.GetMouseButtonDown(0) ) {
					nfo.transform.GetComponent<addLove>().giveLoveToCounter();
				}
			}
		}
	}
}
