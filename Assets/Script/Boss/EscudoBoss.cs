using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoBoss : MonoBehaviour
{
    public int hits;

    public Transform prefabDoEscudo;
    public Transform spawnDoEscudo;

    Transform escudoAtivo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AtivarEscudo()
    {
        escudoAtivo = Instantiate(prefabDoEscudo, spawnDoEscudo.position, spawnDoEscudo.rotation);
        hits = UnityEngine.Random.Range(5,10);
    }

    public void QuebrarEscudo()
    {
        Destroy(escudoAtivo.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hits--;
        if (hits <= 0) 
        {
            QuebrarEscudo();
        }
    }

}
