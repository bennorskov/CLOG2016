using UnityEngine;
using System.Collections;

public class clickCatAlternate : MonoBehaviour {
	public int catID;
	void OnMouseDown() {
		//send message to parent with info on how to rotate
		SendMessageUpwards("rotate", catID );
	}
	void Update() {
		//to keep the cat's head pointed skyward. 
		transform.rotation = Quaternion.identity;
	}
}
