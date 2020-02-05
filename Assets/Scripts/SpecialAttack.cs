using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialAttack : MonoBehaviour
{
    
    public Slider slider;

    public Material mat;
    public Material invmat;
    
    public GameObject marble;
    public Transform shootPoint;
    public Vector3 velocity;

    private GameObject player;

    public void Start(){
        player =  GameObject.FindGameObjectsWithTag("Player")[0];
    }

    public void call(){

        if (slider.value<0.99f)
        {
            return;
        }

            slider.value=0f;

        string sp = PlayerPrefs.GetString("special","Shoot");
        Debug.Log(sp);
        if (sp=="Invisible")
        {
            StartCoroutine(invisible());
        }else if(sp=="Shoot"){
            shoot();
        }else if(sp=="Slow Down"){
            StartCoroutine(slowdown());
        }
    
    }

    IEnumerator invisible(){

        player.GetComponent<MeshRenderer>().material = invmat;
        player.GetComponent<Rigidbody>().useGravity = false;
        player.GetComponent<BoxCollider>().isTrigger = true;
        yield return new WaitForSeconds(4f);
        player.GetComponent<BoxCollider>().isTrigger = false;
        player.GetComponent<Rigidbody>().useGravity = true;
        player.GetComponent<MeshRenderer> ().material = mat;
    }

    private void shoot(){

        GameObject gb = Instantiate(marble, shootPoint.position, shootPoint.rotation);
        gb.GetComponent<Rigidbody>().velocity = velocity;
        
    }

    IEnumerator slowdown(){
        
        Time.timeScale = 1f/4f;
        yield return new WaitForSeconds(8f/4f);
        Time.timeScale = 1.0f;

    }

}
