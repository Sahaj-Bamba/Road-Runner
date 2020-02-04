using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Text;

public class scorers : MonoBehaviour {

	public InputField name;
	public Text scr;
	public Button bt;

	void Start() {
		scr.text = PlayerPrefs.GetString("Score", "");	
	}

	public void call(){
		bt.interactable = false;
		StartCoroutine(scre());
	}

	IEnumerator scre(){

		
		WWWForm form = new WWWForm();

		form.AddField("name",name.text);
		form.AddField("score", Int32.Parse(scr.text));
		form.AddField("level", PlayerPrefs.GetString("level", "level1"));

		scr.fontSize = 50;

		using (UnityWebRequest www = UnityWebRequest.Post("https://blankseed.000webhostapp.com/RoadRunner/submit.php", form))
		{
			yield return www.SendWebRequest();

			if (www.isNetworkError || www.isHttpError)
			{
				scr.text = www.error;
				Debug.Log("Our Server is currently having some problems. Please Try again Latter.");
			}
			else
			{
				scr.text = "Your score of level "+PlayerPrefs.GetString("level", "level1")+" has been successfully saved\nin the imperial scroll of honour";
				Debug.Log("Form upload complete!");
			}
		}

	}
}
