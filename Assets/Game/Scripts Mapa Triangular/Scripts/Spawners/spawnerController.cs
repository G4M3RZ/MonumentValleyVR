using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerController : MonoBehaviour
{
    public GameObject Player;
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public bool terminarContador = false;
    public float contador = 2.3f;
    public int cambiador = 0;
    public int cambSpawn = 1;
    public float contadorDificulty;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (terminarContador == false && Player.GetComponent<Player>().PlayerDead == false)
        {
            Contador();
            Spawn();
        }
        CambiadorDeSwitch();
    }
    void Spawn()
    {
        switch (cambiador)
        {
            case 1: spawner1.GetComponent<Spawner>().spawn = true; cambiador = 0; cambSpawn = 1; break;
            case 2: spawner2.GetComponent<Spawner2>().spawn = true; cambiador = 0; cambSpawn = 1; break;
            case 3: spawner3.GetComponent<Spawner3>().spawn = true; cambiador = 0; cambSpawn = 1; break;
        }
    }
    void CambiadorDeSwitch()
    {
        if (contador == 0f)
        {
            switch (cambSpawn)
            {
                case 1: cambiador = Random.Range(1,4); contador = contadorDificulty; break;
            }
        }
    }
    void Contador()
    {
        contador = contador - 1 * Time.deltaTime;
        if (contador < 0)
        {
            contador = 0;
        }
    }
}