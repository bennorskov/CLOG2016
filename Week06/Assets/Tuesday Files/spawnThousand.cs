	using UnityEngine;
using System.Collections;

public class spawnThousand : MonoBehaviour {

	public GameObject thingToSpawn;

	public int numToSpawn = 1000;

	GameObject[] storedSpawns;

	// populate a space with objects
	void Start () {
		Debug.Log(Random.insideUnitSphere * 30);
		storedSpawns = new GameObject[numToSpawn];
		for (int i = 0; i<storedSpawns.Length; i++) {
			Vector3 cubePos = new Vector3( Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f) );
			storedSpawns[i] = Instantiate(thingToSpawn, cubePos * 30, Quaternion.identity) as GameObject;
		}
	}
	
	void Update () {
	}
}
