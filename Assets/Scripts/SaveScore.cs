using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System;
using System.Text;

public class SaveScore : MonoBehaviour {

	public InputField name;
	public Text scr;


	public void call(){
		gameObject.GetComponent<Button>().interactable = false;

		StartCoroutine(scre());
	}

	IEnumerator scre(){
	
		WWWForm form = new WWWForm();

		form.AddField("name",name.text);
		form.AddField("score",Int32.Parse(scr.text));

		using (UnityWebRequest www = UnityWebRequest.Post("https://blankseed.000webhostapp.com/RoadRunner/submit.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
            	Debug.Log(www.error);
				scr.fontSize = 50;
				scr.text=www.error;
		    }
            else
            {
	        	Debug.Log("Your score has been successfully saved in the imperial scroll of honour");
				scr.fontSize = 50;
				scr.text="Your score has been successfully saved\nin the imperial scroll of honour";
		    }
        }
	}

}
