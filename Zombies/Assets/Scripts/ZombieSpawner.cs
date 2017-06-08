using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

	public GameObject ZombieToSpawn;
	public int ZombieNumbers; // tracks total amount spawned	
		
	// Update is called once per frame
	void Update () {
		Spawn();
	}
	
	IEnumerator Spawn() {
		// test, will spawn 1 every 5sec
		Debug.Log("Spawned");
		ZombieNumbers += 1;
		yield return new WaitForSeconds(5);
	}
}
