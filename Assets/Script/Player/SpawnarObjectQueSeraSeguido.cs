using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnarObjectQueSeraSeguido : MonoBehaviour
{
    //Transform player;
    public Transform ObjetoASerSeguido;
    public float tempoDeSpawn;
    public float tempoDeMorte;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player").gameObject.GetComponent<Transform>();
        
        tempoDeSpawn = UnityEngine.Random.Range(3,5);
        tempoDeMorte = tempoDeSpawn;
    }

    void Update()
    {
        tempoDeMorte -= Time.deltaTime + 5;
        tempoDeSpawn -= Time.deltaTime;
        if( tempoDeSpawn <= 0)
        {
            SpawnObjeto();
        }
    }

    void SpawnObjeto()
    {
        Transform ob = Instantiate(ObjetoASerSeguido, transform.position, transform.rotation);
        Destroy(ob.gameObject, tempoDeMorte);
    }
}
