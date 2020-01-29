using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawn : MonoBehaviour {

	public Transform[] spawn_points;
	public GameObject block;
	public GameObject coin;
	private float time_to_spawn = 1.5f;
	private float time_to_wave = 3f;
	private int gaps=5;
	public Text scr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Time.time>=time_to_spawn){
			spawn_();
			time_to_spawn = Time.time + time_to_wave;
		}

		
	}

	void spawn_()
	{

		int temp;
		int.TryParse(scr.text, out temp);
		if (temp < 1000)
		{
			gaps = 1;
		}
		else if (temp < 2000)
		{
			gaps = 2;
		}
		else if (temp < 6000)
		{
			gaps = 3;
		}
		else if (temp < 10000)
		{
			gaps = 4;
		}
		else if (temp > 10000)
		{
			gaps = 5;
		}




		int[] idx = { 0, 0, 0, 0, 0 };
		int[] X = { 0, 0, 0, 0, 0, 0, 0 };
		for (i = 0; i < gaps; i++)
		{
			X[Random.Range(0, spawn_points.Length)] = 1;
		}
		
		int f;
		for (int i = 0; i < spawn_points.Length; i++)
		{
			f = X[i];
			
			tp = Random.Range(0, 5);
			
			if (f == 1 )
			{
				if(tp != 0)
                {
					Instantiate(block, spawn_points[i].position, Quaternion.identity);
                }
                else
                {
					Instantiate(coin, spawn_points[i].position, Quaternion.identity);
				}

			}
		}



		/*int tp;
		do
		{
		idx[1] = Random.Range(0,spawn_points.Length);	
		} while (X[idx[1]]==1);
		X[idx[1]]=1;
		do
		{
		idx[2] = Random.Range(0,spawn_points.Length);	
		} while (X[idx[2]]==1);
		X[idx[2]]=1;
		do
		{
		idx[3] = Random.Range(0,spawn_points.Length);	
		} while (X[idx[3]]==1);
		X[idx[3]]=1;
		do
		{
		idx[4] = Random.Range(0,spawn_points.Length);	
		} while (X[idx[4]]==1);
		X[idx[4]]=1;
		*/


	}

}
