
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ender : MonoBehaviour {

	private float slow_fac = 50f;
	//public Rigidbody rb;
	public int game_controller=0;
	public GameObject pn;
	public GameObject jump, duck;

	public void end() {
		if(game_controller == 0){
			StartCoroutine(Restart());
		}
		
	}

	IEnumerator Restart(){

		//Debug.Log("Restart");

		game_controller = 1;
		Time.timeScale = 1f/slow_fac;
		Time.fixedDeltaTime /= slow_fac;

		yield return new WaitForSeconds(2f/slow_fac);
		
		Time.timeScale = 1f;
		Time.fixedDeltaTime = 0.002f;

		pn.SetActive(true);
		jump.SetActive(false);
		duck.SetActive(false);

		//SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex);

		//Debug.Log(Time.fixedDeltaTime);

	}
}
