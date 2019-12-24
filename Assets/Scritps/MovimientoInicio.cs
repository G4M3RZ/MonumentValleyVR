using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoInicio : MonoBehaviour {

    float speed = 120;
    public GameObject Mapa;

	// Use this for initialization
	void Start ()
    {
        speed = 120;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.z <= 63)
        {
            speed = 0;
            Mapa.GetComponent<Scroll>().scrolly = 0.5f;
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 63);
        }
        else
        {
            Movimiento();
        }
	}
    void Movimiento()
    {
        transform.Translate(0, -1 * Time.deltaTime * speed, 0);
        Mapa.GetComponent<Scroll>().scrolly = 0;
    }
}
