using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInteractivoPlay : MonoBehaviour {
    public GameObject PlayButon;
    public GameObject OptionsButton;

    public GameObject fadeInicial;
    public GameObject fadeFinal;

    private bool CambioScena = true;
    private float contadorCmabioSenas = 1.5f;
    // Use this for initialization
    void Start ()
    {
        Instantiate(fadeInicial, new Vector3(0, 0, -2.15f), transform.rotation);
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayGame();
        OptionsGame();
    }
    public void PlayGame()
    {
        if (PlayButon.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            if (CambioScena)
            {
                Instantiate(fadeFinal, new Vector3(0, 0, -2.15f), transform.rotation);
                CambioScena = false;
            }
            contadorCmabioSenas -= Time.deltaTime;
            if(contadorCmabioSenas <= 0)
            {
                PlayButon.GetComponent<BotonInteractivo>().ActivarBoton = false;
                SceneManager.LoadScene(1);
            }
        }
    }
    public void OptionsGame()
    {
        if (OptionsButton.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            if (CambioScena)
            {
                Instantiate(fadeFinal, new Vector3(0, 0, -2.15f), transform.rotation);
                CambioScena = false;
            }
            contadorCmabioSenas -= Time.deltaTime;
            if (contadorCmabioSenas <= 0)
            {
                OptionsButton.GetComponent<BotonInteractivo>().ActivarBoton = false;
                SceneManager.LoadScene(2);
            }
        }
    }
}
