using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {
    //private Vector3 rotation;
    public float currentRotationZ;
    public bool AllStop = true;

	// Use this for initialization
	void Start ()
    {
        currentRotationZ = 0;
	}
	// Update is called once per frame
	void Update () {
        if (AllStop)
        {
            currentRotationZ -= transform.rotation.z * Time.deltaTime * 50;
            //transform.eulerAngles=new Vector3(0,0,transform.eulerAngles.z);
        //transform.localPosition=Vector3.zero;
        }
    }
    public float GetCurrentRotationZ()
    {
        return currentRotationZ;
    }
}
