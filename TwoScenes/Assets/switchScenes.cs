using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class switchScenes : MonoBehaviour {

	public static switchScenes thisScript;
	// the "static" means there can only be one instance of this variable

	void Awake () {
		if (thisScript == null) {
			DontDestroyOnLoad(gameObject);
			thisScript = this;
			// store a reference to this instance of the switchScenes class
		} else if (thisScript != this) {
			// if "thisScript" is not the current instance of the switchScenes class
			Destroy(gameObject); //destroy this gameObject
		}
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.D)) {
			SceneManager.LoadScene("Scene2");
		}
		if (Input.GetKey(KeyCode.S)) {
			SceneManager.LoadScene("Scene1");
		}

	}
}




















