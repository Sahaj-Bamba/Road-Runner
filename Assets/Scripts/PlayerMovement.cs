using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour {

	public Text a;

	public float frd_force = 500f;
	public float side_force = 500f;

	private bool right_move=false;
	private bool left_move=false;
	
	private int cnt = 0;
	private int bonus = 0;

	private Rigidbody rb;
	private Transform tra;

	void Start() {
		rb = GetComponent<Rigidbody>();
		tra = GetComponent<Transform>();
	}

	void Update(){
		
		if(Input.GetKey("d") ){
			right_move = true;
		}
		else
		{
			right_move = false;
		}
		if(Input.GetKey("a")){
			left_move = true;
		}
		else{
			left_move = false;
		}

	}

	void FixedUpdate () {

		if(cnt>0){
			cnt=0;
			FindObjectOfType<ender>().end();
		}

		Vector3 temp = tra.position;

		if(tra.position.x > -6){
			if (left_move == true)
			{
				rb.AddForce(-1*side_force * Time.deltaTime,0,0,ForceMode.VelocityChange);
			}	
		}
		if(tra.position.x < 6f){
			if (right_move==true)
			{
				rb.AddForce(side_force * Time.deltaTime,0,0,ForceMode.VelocityChange);
			}
		}

		if(tra.position.x > 6f){
			temp.x = 6f;
			transform.position = temp;
		}
		else if(tra.position.x < -6){
			temp.x = -1*6f;
			transform.position = temp;
		}

	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "barrier"){
			col.gameObject.GetComponent<Rigidbody>().AddForce (0, 0, frd_force,ForceMode.VelocityChange);
			Vector3 te = col.gameObject.GetComponent<Transform>().position;
			te.z-=1;
			col.gameObject.GetComponent<Transform>().position = te;
			cnt++;
		}
		else if (col.gameObject.tag == "bonus")
		{
			bonus++;
			a.text = (int.Parse(a.text) + bonus * 1000).ToString("0");
			col.gameObject.GetComponent<Transform>().localScale = new Vector3(0,0,0);
			Destroy(col.gameObject);
		}
	}

 }
