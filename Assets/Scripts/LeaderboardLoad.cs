using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LeaderboardLoad : MonoBehaviour {

	public Text []_score;
	public Text []_name;
	public Text msg;

	void Start(){
		StartCoroutine(scr());
	}

	IEnumerator scr(){
		
		string uri="www.youtube.com";		
		using (UnityWebRequest webRequest = UnityWebRequest.Get("https://blankseed.000webhostapp.com/RoadRunner/retrive.php"))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
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
