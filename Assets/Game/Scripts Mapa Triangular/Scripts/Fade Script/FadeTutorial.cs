using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTutorial : MonoBehaviour {

    public Material ColorInicial;
    public float Speed = 0.5f;

    private float alpha = 1f;

    // Use this for initialization
    void Start ()
    {
        alpha = 1f;
        gameObject.GetComponent<Renderer>().material = ColorInicial;
        ColorInicial.color = new Color(1, 1, 1, alpha);
    }
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.GetComponent<Renderer>().material = ColorInicial;
        ColorInicial.color = new Color(1, 1, 1, alpha);
        if (alpha >= 0)
        {
            alpha -= Speed * Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
