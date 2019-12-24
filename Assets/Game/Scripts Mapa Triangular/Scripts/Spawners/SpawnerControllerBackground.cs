using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControllerBackground : MonoBehaviour {

    public Transform[] spawnLocation;
    public GameObject[] prefab;
    public GameObject[] clone;
    public GameObject menuPausa;

    int randomNum;
    int randomNum2;
    int cambiador;

    float contador = 2f;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (menuPausa.GetComponent<MenuInteractivoInGame>().IsPause == false)
        {
            ContadorRandom();
            Spawn();
        }
    }
    void Spawn()
    {
        switch (cambiador)
        {
            case 1: clone[randomNum] = Instantiate(prefab[randomNum], spawnLocation[randomNum2].transform.position, Quaternion.Euler(-90, 0, 0)) as GameObject; break;
            case 2: clone[randomNum] = Instantiate(prefab[randomNum], spawnLocation[randomNum2].transform.position, Quaternion.Euler(-90, 0, 0)) as GameObject; break;
            default: break;
        }
    }
    void ContadorRandom()
    {
        if (contador >= 0)
        {
            contador -= Time.deltaTime;
            cambiador = 0;
        }
        else
        {
            randomNum = Random.Range(0, 2);
            randomNum2 = Random.Range(0, 2);
            cambiador = Random.Range(1, 3);
            contador = 2f;
        }
        
    }
}
