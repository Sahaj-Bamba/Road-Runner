using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LeaderboardLoad : MonoBehaviour {

	public Text []_score;
	public Text []_name;
	public Text msg;
	private int currentLevel=1;
	public int maxLevel=4;

	public void Start()
    {
		StartCoroutine(scr());
	}

	public void nextLevel(){
		if (currentLevel == maxLevel){
			return;
		}
		currentLevel++;
		StartCoroutine(scr());
	}

	public void previousLevel(){
		if (currentLevel == 1){
			return;
		}
		currentLevel--;
		StartCoroutine(scr());
	}

	IEnumerator scr(){
		
		using (UnityWebRequest webRequest = UnityWebRequest.Get("https://blankseed.000webhostapp.com/RoadRunner/retrive.php?level=level"+currentLevel))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

         
            if (webRequest.isNetworkError || webRequest.isHttpError)
            {
				msg.text = ": Error: " + webRequest.error;
                Debug.Log( ": Error: " + webRequest.error);
            }
            else
            {
				msg.text = "";
				// msg.text = ":\nReceived: " + webRequest.downloadHandler.text;
				// Debug.Log( ":\nReceived: " + webRequest.downloadHandler.text);
				string []res = webRequest.downloadHandler.text.Split('+');
				Debug.Log(res);
				
				int a=0,b=0;
				Debug.Log(res[0]);

				for(int i=1;i<res.Length&&i<11;){
					if(i%2==0){
						_score[b++].text=res[i++];
					}
					else{
						_name[a++].text=res[i++];
					}
				}
			
		    }
        }
		/*
		WWW w = new WWW ("https://ltss.000webhostapp.com/unity/retrive.php");

		yield return w;	

		Debug.Log(w.text);
		string []res = w.text.Split('+');
		Debug.Log(res);
		if(res[0] == "0"){
			Debug.Log("Connection error");
			msg.text="Connection error";
		}
		else{
		
			int a=0,b=0;
			Debug.Log(res[0]);

			for(int i=1;i<res.Length&&i<11;){
				if(i%2==0){
					_score[b++].text=res[i++];
				}
				else{
					_name[a++].text=res[i++];
				}
			}

		}*/
	}

}
