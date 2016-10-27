using UnityEngine;
using System.Collections;

public class fenceSpawner : MonoBehaviour {

	public Transform fence;
	public float heightVariablilty = 8;

	// Use this for initialization
	void Start () {
		InvokeRepeating("spawnFence", 2f, 2f);
	}
	
	void spawnFence () {
		Vector3 spawnPos = transform.position + Vector3.up * (Random.value * heightVariablilty - heightVariablilty*.5f);
		spawnPos.z = 2;
		Instantiate(fence, spawnPos, Quaternion.identity);
	}
}
