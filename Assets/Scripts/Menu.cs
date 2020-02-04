using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void StartGame(){
		Time.timeScale = 1.0f;
		SceneManager.LoadScene(4);
	}

	public void load(string x)
	{
		PlayerPrefs.SetString("level", x);
		SceneManager.LoadScene(x);
	}

	public void LevelUp()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void StartMenu(){
		Time.timeScale = 1.0f;
		SceneManager.LoadScene(0);
	}

	public void Leaderboard(){
		SceneManager.LoadScene(1);
	}

	public void Instruction(){
		SceneManager.LoadScene(2);
	}

	public void EndGame(){
		Application.Quit();
	}

	public void End(){
		SceneManager.LoadScene("End");	
	}

}
