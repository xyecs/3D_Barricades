using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMechanics : MonoBehaviour {

	public GameObject ThePlayer;
	public GameObject TheZombie;
	public float TargetDistance;
	public RaycastHit Hit;
	public int ZombieStatus; // 0 = not in range, move to player, 1 = in-range of player can attack
	public float ZombieSpeed = 0.1f;	
	Animator ToonZombieAnimator;
	
	void Start () {
		ToonZombieAnimator = GetComponent<Animator>();
	}
	
	void Update () {
		transform.LookAt(ThePlayer.transform);
		if (ZombieStatus == 0) {
			ZombieSpeed = 0.1f;	
			ToonZombieAnimator.SetBool("IsAttacking", false);
			if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit)){
				transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, ZombieSpeed);
			}
		} else {
			ToonZombieAnimator.SetBool("IsAttacking", true);
			ZombieSpeed = 0;	
		}
	}
	
	void OnTriggerEnter () {
		Debug.Log("Zombie Entered");
		ZombieStatus = 1;
	}
	
	void OnTriggerExit () {
		Debug.Log("Zombie Exited");
		ZombieStatus = 0;
	}
}
