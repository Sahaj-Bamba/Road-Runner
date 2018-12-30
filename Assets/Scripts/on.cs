using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class on : MonoBehaviour {

	public void StartGame(){
		SceneManager.LoadScene(1);
	}
	public void menu(){
		SceneManager.LoadScene(0);
	}
	public void leadstart(){
		SceneManager.LoadScene(2);
	}
	public void insstart(){
		SceneManager.LoadScene(3);
	}
}
