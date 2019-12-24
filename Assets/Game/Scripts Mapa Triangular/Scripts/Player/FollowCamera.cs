using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    public RotateCamera compRotateCamera;
    public GameObject MenuInteractivoInGame;
    private float initialPosX;
    private float movementFactor = 1.5f;

	// Use this for initialization
	void Start ()
    {
        initialPosX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        float rotY = compRotateCamera.GetCurrentRotationZ();
        float offset = rotY * movementFactor;
        if (MenuInteractivoInGame.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            transform.position = new Vector3(initialPosX + offset, transform.position.y, transform.position.z);
        }
        if (offset >= 15)
        {
            offset = 15;
        }
        if (offset <= -15)
        {
            offset = -15;
        }
    }
}
