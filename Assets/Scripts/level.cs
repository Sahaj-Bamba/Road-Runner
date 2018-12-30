using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<obstacle_mov>().frd_force -= Time.timeSinceLevelLoad*1000f;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z<-10f)
		{
			Destroy(gameObject);
		}
	}
}
