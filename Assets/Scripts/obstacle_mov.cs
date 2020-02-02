using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_mov : MonoBehaviour {

	public float frd_force = -1000f;
	public float shootVel = 100f;
	private Rigidbody rb;
	
	void Start(){

		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3(0,0,-1) * shootVel;
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	 
		rb.AddForce(0,0,frd_force*Time.deltaTime);
		
		
	}
}
