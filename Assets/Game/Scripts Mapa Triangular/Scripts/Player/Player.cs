using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Player : MonoBehaviour {
    public bool PlayerDead = false;
    public bool PowerUP = false;
    public bool SecondLife = false;
    public GameObject ParticulasSecondLife;
    public GameObject secondLife;
    public GameObject explosionParticulas;
    public GameObject mainCamera;
    public GameObject obsEnd;

    public float cameraLimits = 2.3f;
    public float playerLimits = 3.4f;
    public float playerRotation = 20;
    void Awake()
    {
        
    }
    // Use this for initialization
    void Start ()
    {
        /* 
        XRDevice.DisableAutoXRCameraTracking(mainCamera.GetComponent<Camera>(),true);
        InputTracking.disablePositionalTracking=true;
        */
    }
	// Update is called once per frame
	void Update ()
    {
        Limites();
        MovimientoNaranja();
        SecondLifeChange();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (PowerUP == false && SecondLife == false)
            {
                PlayerDead = true;
                obsEnd.GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = false;
            }
            SecondLife = false;
            Instantiate(explosionParticulas, transform.position, transform.rotation);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "secondLife")
        {
            SecondLife = true;
        }
    }
    public void Limites()
    {
        if (transform.localPosition.x <= -playerLimits)
        {
            this.gameObject.transform.localPosition = new Vector3(-playerLimits, transform.localPosition.y, transform.localPosition.z);
            if (mainCamera.GetComponent<RotateCamera>().currentRotationZ <= -cameraLimits)
            {
                mainCamera.GetComponent<RotateCamera>().currentRotationZ = -cameraLimits;
            }
        }
        if (transform.localPosition.x >= playerLimits)
        {
            this.gameObject.transform.localPosition = new Vector3(playerLimits, transform.localPosition.y, transform.localPosition.z);
            if (mainCamera.GetComponent<RotateCamera>().currentRotationZ >= cameraLimits)
            {
                mainCamera.GetComponent<RotateCamera>().currentRotationZ = cameraLimits;
            }
        }
    }
    void MovimientoNaranja()
    {
        transform.Rotate(0, 0, playerRotation * Time.deltaTime * 50);
    }
    void SecondLifeChange()
    {
        if (SecondLife && PlayerDead == false)
        {
            //GetComponent<MeshRenderer>().enabled = false;
            //secondLife.GetComponent<MeshRenderer>().enabled = true;
            ParticulasSecondLife.SetActive(true);
        }
        if(SecondLife == false && PlayerDead == false)
        {
            //GetComponent<MeshRenderer>().enabled = true;
            //secondLife.GetComponent<MeshRenderer>().enabled = false;
            ParticulasSecondLife.SetActive(false);
        }
    }
}
