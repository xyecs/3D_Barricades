using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMechanics : MonoBehaviour {

	public GameObject ThePlayer;
	public GameObject TheEnemy;
	public float TargetDistance;
	public float AllowedRange = 10;
	public RaycastHit hit;
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(ThePlayer.transform);
	}
}
