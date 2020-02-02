using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorer : MonoBehaviour {

	public Text []_score;
	public Text []_name;

	void Start(){
		StartCoroutine(scr());
	}

	IEnumerator scr(){

		// Text []_score = Text.FindGameObjectsWithTag("SCORE");
		// Text []_name = GameObject.FindGameObjectsWithTag("NAME");

		WWW w = new WWW ("https://ltss.000webhostapp.com/unity/rerive.php");

		yield return w;	

		string []res = w.text.Split('\t');

		if(res[0] == "0"){
			Debug.Log("Connection error");
		}
		else{
			//Debug.Log("Your score has been successfully saved in the imperial scroll of honour");
		}

		for(int i=1;i<res.Length;){
			if(i%2==0){

			}
			else{

			}
		}

	}
}
