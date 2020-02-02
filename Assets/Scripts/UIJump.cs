using UnityEngine;
using UnityEngine.EventSystems;

public class UIJump : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public float upVel = 10.0f;
    public float fallMultiplier = 2.0f;
    public float shortJumpMultiplier = 1.5f;
    public Rigidbody rb;
    public Transform tf;
    private bool isDown = false;
    


    public void OnPointerDown(PointerEventData eventData)
    {
        this.isDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.isDown = false;
    }

    void FixedUpdate()
    {
        
        //if (!this.isDown) return;
        jump();
        /*if (Time.realtimeSinceStartup - this.downTime > 2f)
                {
                    print("Handle Long Tap");
                    this.isDown = false;
                }*/
    }


    void jump()
    {
        /*if (tf.localScale.y == 1 )
        {
            if (rb.velocity.y == 0)
            {
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
        }
        else if (tf.localScale.y < 1.0f && ducking == false)
        {
            tf.localScale += Vector3.up * 0.5f * Time.deltaTime;
        }
        if (tf.localScale.y <= 0.5f)
        {
            ducking = false;
        }
        */


        if (rb.velocity.y == 0 && isDown)
        {
            Debug.Log("Hi");
            rb.velocity += Vector3.up * upVel;
        }
        else if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        if (rb.velocity.y > 0 && !isDown)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (shortJumpMultiplier - 1) * Time.deltaTime;
        }
    }

}