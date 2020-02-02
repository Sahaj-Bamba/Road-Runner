using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acc_mob : MonoBehaviour {

    public float multiplier = 8.0f;
       
	void FixedUpdate () {
        transform.Translate(Input.acceleration.x*1f/multiplier, 0, 0);
    }
    
}
