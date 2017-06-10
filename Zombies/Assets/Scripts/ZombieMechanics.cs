using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMechanics : MonoBehaviour {

	public GameObject ThePlayer;
	public GameObject TheZombie;
	public float TargetDistance;
	public RaycastHit Hit;
	public int ZombieStatus; // 0 = not in range, move to player, 1 = in-range of player can attack
	public float ZombieSpeed = 0.02f;	
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(ThePlayer.transform);
		if (ZombieStatus == 0) {
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit)){
				transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, ZombieSpeed);
			}
		} 
	}
	
	void OnTriggerEnter () {
		ZombieStatus = 1;
		ZombieSpeed = 0;	
	}
	
	void OnTriggerExit () {
		ZombieStatus = 0;
		ZombieSpeed = 0.1f;	
	}
}
