using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_mov : MonoBehaviour {

	public float frd_force = -1000f;
	private Rigidbody rb;
	void Start(){

		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	 
		rb.AddForce(0,0,frd_force*Time.deltaTime);
		
		
	}
}
