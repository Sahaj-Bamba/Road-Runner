using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class FeedBackSubmit : MonoBehaviour
{

    public InputField name;
	public InputField content;
	public Button bt;

	public void call(){
		bt.interactable = false;
		StartCoroutine(scre());
	}

	IEnumerator scre(){

		
		WWWForm form = new WWWForm();

		form.AddField("name",name.text);
		form.AddField("content", content.text);
		
        content.text = "Please wait for a moment while we are recording your wisdom. ";

		using (UnityWebRequest www = UnityWebRequest.Post("https://blankseed.000webhostapp.com/RoadRunner/feed.php", form))
		{
			yield return www.SendWebRequest();

			if (www.isNetworkError || www.isHttpError)
			{
				content.text = "Our Server is currently having some problems. Please Try again latter.";
				Debug.Log("Our Server is currently having some problems. Please Try again Latter.");
			}
			else
			{
				content.text = "Your golden words have been successfully saved \n in the imperial scroll of wisdom and we will look into them.";
				Debug.Log("Form upload complete!");
			}
		}

	}

}
