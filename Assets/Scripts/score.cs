using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour {
	
	public Text scr;
	public GameObject en_cnt;
	public Slider slider;
	public int maxValue; 

	// Update is called once per frame
	void Update () {
		
		if(en_cnt.GetComponent<ender>().game_controller==0){
			scr.text = (int.Parse(scr.text) + (Time.deltaTime*100)).ToString("0") ;
			float x = slider.value + (Time.deltaTime*100.0f)/maxValue;
			if(x>=1.0f){
				x = 1.0f;
			}
			slider.value = x;
		}
	}

}
