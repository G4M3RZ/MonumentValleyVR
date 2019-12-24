using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPowerUP : MonoBehaviour {
    public float speed = 50;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, 0, -1 * Time.deltaTime * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstEnd")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
