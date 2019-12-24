using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObj : MonoBehaviour {

    private bool Up;
    private bool Down;

    private float time;
	// Use this for initialization
	void Start ()
    {
        Up = true;
        Down = false;
        time = 0.8f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Up)
        {
            transform.Translate(0, 1 * Time.deltaTime, 0);
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = 0.8f;
                Up = false;
                Down = true;
            }
        }
        else if(Down)
        {
            transform.Translate(0, -1 * Time.deltaTime, 0);
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = 0.8f;
                Up = true;
                Down = false;
            }
        }
        transform.Rotate(0, 150 * Time.deltaTime, 0);
	}
}
