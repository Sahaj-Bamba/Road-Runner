
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ender : MonoBehaviour {

	private float slow_fac = 50f;
	public int game_controller=0;
	public Text score;

	public void end() {
		if(game_controller == 0){
			PlayerPrefs.SetString("Score", score.text);
			StartCoroutine(Restart());
		}
		
	}

	IEnumerator Restart(){

		game_controller = 1;
		Time.timeScale = 1f/slow_fac;
		Time.fixedDeltaTime /= slow_fac;

		yield return new WaitForSeconds(2f/slow_fac);
		
		Time.timeScale = 1f;
		Time.fixedDeltaTime = 0.002f;

		
	 	Debug.Log("Ender");
		SceneManager.LoadScene("End");

	}
}
