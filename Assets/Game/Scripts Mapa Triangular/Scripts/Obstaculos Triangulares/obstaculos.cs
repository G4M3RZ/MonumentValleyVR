using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour {
    public float speed;
    public Rigidbody rb;
    // Use this for initialization
    private void Awake()
    {
        rb.GetComponent<Rigidbody>();
    }
    void Start()
    {
        //rb.velocity = new Vector3(0, 0, -speed * Time.deltaTime * 70);
        GetComponent<Rigidbody>().AddForce(0, 0, -speed * 55);
    }
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0, 1 * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstEnd")
        {
            Destroy(this.gameObject);
        }
    }
}
