using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour {
	private static audioScript audio;
	// Use this for initialization
	void Start () 
	{
		if(audio==null)
		{
			audio=this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
