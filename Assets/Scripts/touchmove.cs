using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchmove : MonoBehaviour {

	public Rigidbody rb;
	public Transform ply;

	public float side_force = 20f;

	private bool right_move=false;
	private bool left_move=false;


	// Update is called once per frame
	void Update () {
		int x=Input.touchCount;
		//Debug.Log(x);
		if (x > 0)
		{
			Touch th = Input.GetTouch(0);
			Debug.Log(th.position.x);
			if(th.position.x>Screen.width/2f){
				right_move = true;
			}
			else
			{
				right_move = false;
			}
			if(th.position.x<Screen.width/2f){
				left_move = true;
			}
			else{
				left_move = false;
			}
		}
		else{
			right_move = false;
			left_move = false;
		}
	}

	void FixedUpdate () {
		

		//Debug.Log(ply.position.x);

		Vector3 temp = ply.position;

		if(ply.position.x > -5.5){
			if (left_move == true)
			{
				rb.AddForce(-1*side_force * Time.deltaTime,0,0,ForceMode.VelocityChange);
			}	
		}

		if(ply.position.x < 5.5){
			if (right_move==true)
			{
				rb.AddForce(side_force * Time.deltaTime,0,0,ForceMode.VelocityChange);
			}
		}
		if(ply.position.x > 5.5){
			temp.x = 5.5f;
			ply.position = temp;
		}
		else if(ply.position.x < -5.5){
			temp.x = -1*5.5f;
			ply.position = temp;
		}
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "barrier"){
			//Debug.Log("Hi");

			FindObjectOfType<ender>().end();
		}

	}

}
