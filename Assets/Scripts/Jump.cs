using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

	public float upVel = 10.0f;
	public float fallMultiplier = 2.0f;
	public float shortJumpMultiplier = 1.5f;
	private Rigidbody rb;
	private Transform tf;
	private bool ducking = false;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		tf = GetComponent<Transform>();
	}

	// Update is called once per frame
	void FixedUpdate()
    {
		
		if (tf.localScale.y == 1 && Input.GetButton("Fire1") )
		{
			if(rb.velocity.y == 0) {
				ducking = true;
            }
            else
            {
				rb.velocity -= Vector3.up * 2; 
            }
		}
		else if (ducking == true)
		{
			tf.localScale -= Vector3.up * 0.5f * Time.deltaTime * 2;
		}else if(tf.localScale.y < 1.0f && ducking==false)
        {
			tf.localScale += Vector3.up * 0.5f * Time.deltaTime;
		}
		if (tf.localScale.y <= 0.5f)
		{
			ducking = false;
		}



		if (rb.velocity.y == 0 && Input.GetButton("Jump"))
        {
			Debug.Log("Hi");
			rb.velocity += Vector3.up * upVel;
        }else if (rb.velocity.y < 0)
		{
			rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		}
		if (rb.velocity.y > 0 && ! Input.GetButton ("Jump") )
		{
			rb.velocity += Vector3.up * Physics.gravity.y * (shortJumpMultiplier - 1) * Time.deltaTime;
		}
	}

}
