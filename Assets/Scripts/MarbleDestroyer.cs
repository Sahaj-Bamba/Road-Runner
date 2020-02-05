using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleDestroyer : MonoBehaviour
{
    public float leaveTime = 15f;

    void Start()
    {
        StartCoroutine(destroy());
    }

    private IEnumerator destroy()
    {

        yield return new WaitForSeconds(leaveTime);
        Destroy(gameObject);       

    }


    void OnCollisionEnter(Collision col){
        
        if (col.gameObject.tag == "barrier" || col.gameObject.tag == "bonus")
        {
            col.gameObject.GetComponent<Transform>().localScale = new Vector3(0,0,0);
            Destroy(col.gameObject);
        }

    }
}
