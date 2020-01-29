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


	public void call(){
		gameObject.GetComponent<Button>().interactable = false;

		StartCoroutine(scre());
	}

	IEnumerator scre(){

		
		WWWForm form = new WWWForm();

		form.AddField("name",name.text);
		form.AddField("score", Int32.Parse(scr.text));
		form.AddField("level", SceneManager.GetActiveScene().name);


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
				scr.text = "Your score has been successfully saved\nin the imperial scroll of honour";
				Debug.Log("Form upload complete!");
			}
		}

		/*
		WWW w = new WWW ("https://ltss.000webhostapp.com/unity/submit.php",form);

		yield return w;	

		if(w.text == "0"){
			Debug.Log("Connection error");
		}
		else{
			Debug.Log("Your score has been successfully saved in the imperial scroll of honour");
			scr.fontSize = 50;
			scr.text="Your score has been successfully saved\nin the imperial scroll of honour";
		}*/

	}
}
