using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acc_mob : MonoBehaviour {

    public Transform ts;
    //SerializePrivateVariables
    private int multiplier = 8;
       
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        ts.Translate(Input.acceleration.x*1f/multiplier, 0, 0);
    }
}
