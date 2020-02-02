using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;
public class ld : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
	}



	public Text []_score;
	public Text []_name;

	void Start(){
		StartCoroutine(scr());
	}

	IEnumerator scr(){

		// Text []_score = Text.FindGameObjectsWithTag("SCORE");
		// Text []_name = GameObject.FindGameObjectsWithTag("NAME");

		WWW w = new WWW ("https://ltss.000webhostapp.com/unity/retrive.php");

		yield return w;	

		Debug.Log(w.text);
		string []res = w.text.Split('+');
		_name[0].text = "Serching the elites from the imperial scroll of honour.";
		if(res[0] == "0"){
			Debug.Log("Connection error");
			_name[0].text="Connection error";
		}
		else{
		
			int a=0,b=0;
			Debug.Log("hi");
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



    IEnumerator GetText()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("https://ltss.000webhostapp.com/unity/retrive.php"))
        {
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
            	Debug.Log("hi");
                // Show results as text
                Debug.Log(www.downloadHandler.text);

            	Debug.Log("hi");
                // Or retrieve results as binary data
                //byte[] results = www.downloadHandler.data;
            }
        }
    }

}

