using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuOptionsInteractivo : MonoBehaviour {
    public GameObject ultra;
    public GameObject veryHigh;
    public GameObject high;
    public GameObject medium;
    public GameObject low;
    public GameObject veryLow;
    public GameObject Menu;

    public GameObject fadeInicial;
    public GameObject fadeFinal;

    private bool CambioScena = true;
    private float contadorCmabioSenas = 1.5f;
    // Use this for initialization
    void Start ()
    {
        Instantiate(fadeInicial, new Vector3(0, 0, -2.18f), transform.rotation);

        switch (QualitySettings.currentLevel)
        {
            case QualityLevel.Fantastic:
                ultra.GetComponent<BotonInteractivo>().ActivarBoton=true;
            break;
            case QualityLevel.Beautiful:
                veryHigh.GetComponent<BotonInteractivo>().ActivarBoton=true;
            break;
            case QualityLevel.Good:
                high.GetComponent<BotonInteractivo>().ActivarBoton=true;
            break;
            case QualityLevel.Simple:
                medium.GetComponent<BotonInteractivo>().ActivarBoton=true;
            break;
            case QualityLevel.Fast:
                low.GetComponent<BotonInteractivo>().ActivarBoton=true;
            break;
            case QualityLevel.Fastest:
                veryLow.GetComponent<BotonInteractivo>().ActivarBoton=true;
            break;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        UltraInstinto();
        VeryHigh();
        High();
        Medium();
        Low();
        VeryLow();
        BackToMenu();
    }
    void UltraInstinto()
    {
        if (ultra.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            QualitySettings.currentLevel = QualityLevel.Fantastic;
            ultra.GetComponent<Toggle>().isOn = true;
            veryHigh.GetComponent<Toggle>().isOn = false;
            high.GetComponent<Toggle>().isOn = false;
            medium.GetComponent<Toggle>().isOn = false;
            low.GetComponent<Toggle>().isOn = false;
            veryLow.GetComponent<Toggle>().isOn = false;

            ResetbuttonsCheck();
        }
    }
    void VeryHigh()
    {
        if (veryHigh.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            QualitySettings.currentLevel = QualityLevel.Beautiful;
            ultra.GetComponent<Toggle>().isOn = false;
            veryHigh.GetComponent<Toggle>().isOn = true;
            high.GetComponent<Toggle>().isOn = false;
            medium.GetComponent<Toggle>().isOn = false;
            low.GetComponent<Toggle>().isOn = false;
            veryLow.GetComponent<Toggle>().isOn = false;

            ResetbuttonsCheck();
        }
    }
    void High()
    {
        if (high.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            QualitySettings.currentLevel = QualityLevel.Good;
            ultra.GetComponent<Toggle>().isOn = false;
            veryHigh.GetComponent<Toggle>().isOn = false;
            high.GetComponent<Toggle>().isOn = true;
            medium.GetComponent<Toggle>().isOn = false;
            low.GetComponent<Toggle>().isOn = false;
            veryLow.GetComponent<Toggle>().isOn = false;

            ResetbuttonsCheck();
        }
    }
    void Medium()
    {
        if (medium.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            QualitySettings.currentLevel = QualityLevel.Simple;
            ultra.GetComponent<Toggle>().isOn = false;
            veryHigh.GetComponent<Toggle>().isOn = false;
            high.GetComponent<Toggle>().isOn = false;
            medium.GetComponent<Toggle>().isOn = true;
            low.GetComponent<Toggle>().isOn = false;
            veryLow.GetComponent<Toggle>().isOn = false;

            ResetbuttonsCheck();
        }
    }
    void Low()
    {
        if (low.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            QualitySettings.currentLevel = QualityLevel.Fast;
            ultra.GetComponent<Toggle>().isOn = false;
            veryHigh.GetComponent<Toggle>().isOn = false;
            high.GetComponent<Toggle>().isOn = false;
            medium.GetComponent<Toggle>().isOn = false;
            low.GetComponent<Toggle>().isOn = true;
            veryLow.GetComponent<Toggle>().isOn = false;

            ResetbuttonsCheck();
        }
    }
    void VeryLow()
    {
        if (veryLow.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            QualitySettings.currentLevel = QualityLevel.Fastest;
            ultra.GetComponent<Toggle>().isOn = false;
            veryHigh.GetComponent<Toggle>().isOn = false;
            high.GetComponent<Toggle>().isOn = false;
            medium.GetComponent<Toggle>().isOn = false;
            low.GetComponent<Toggle>().isOn = false;
            veryLow.GetComponent<Toggle>().isOn = true;

            ResetbuttonsCheck();
        }
    }
    void BackToMenu()
    {
        if (Menu.GetComponent<BotonInteractivo>().ActivarBoton)
        {
            if (CambioScena)
            {
                Instantiate(fadeFinal, new Vector3(0, 0, -2.18f), transform.rotation);
                CambioScena = false;
            }
            contadorCmabioSenas -= Time.deltaTime;
            if (contadorCmabioSenas <= 0)
            {
                Menu.GetComponent<BotonInteractivo>().ActivarBoton = false;
                SceneManager.LoadScene(0);
            }
        }
    }
    void ResetbuttonsCheck()
    {
        ultra.GetComponent<BotonInteractivo>().ActivarBoton = false;
        veryHigh.GetComponent<BotonInteractivo>().ActivarBoton = false;
        high.GetComponent<BotonInteractivo>().ActivarBoton = false;
        medium.GetComponent<BotonInteractivo>().ActivarBoton = false;
        low.GetComponent<BotonInteractivo>().ActivarBoton = false;
        veryLow.GetComponent<BotonInteractivo>().ActivarBoton = false;
    }
}
