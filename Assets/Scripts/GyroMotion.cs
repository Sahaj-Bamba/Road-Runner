using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMotion : MonoBehaviour {

	public float multiplier = 0.9f;
    public Transform ply;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float x = Input.acceleration.x*1f;
        Debug.Log(x);
        
		if(x>=0.01f || x<=-0.01f){
			ply.Translate(x*multiplier, 0, 0);
        }
        
        if(x>=0.01f){
			ply.Translate(x*multiplier, 0, 0);
        }
        Debug.Log("x " + ply.position.x);
        if(ply.position.x > 6f){
        	ply.position = new Vector3(5.9f,ply.position.y,ply.position.z);
        	return;
        }else if(ply.position.x < -6f){
        	ply.position = new Vector3(-5.9f,ply.position.y,ply.position.z);
        	return;
        }
    }
    
}
