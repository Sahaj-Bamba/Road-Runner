using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float x = Time.timeSinceLevelLoad*1500f;
		if (x >= 12500.0f ){
			x = 12500.0f;
		}
		GetComponent<obstacle_mov>().frd_force -= x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z<-10f)
		{
			Destroy(gameObject);
		}
	}
}
