using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour {
	public Text scr;
	//public ender END;
	public GameObject en_cnt;

	// Update is called once per frame
	void Update () {
		
		if(en_cnt.GetComponent<ender>().game_controller==0){
			scr.text = (Time.timeSinceLevelLoad*100).ToString("0");
		}
	}
}
