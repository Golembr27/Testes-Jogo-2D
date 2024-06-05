using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoBoss : MonoBehaviour
{
    public int hits;
    public int ativouEscudo = 0;

    public float tempoDeDesativacaoAutomatica;

    public Transform prefabDoEscudo;
    public Transform spawnDoEscudo;

    Transform escudoAtivo;


    // Start is called before the first frame update
    void Start()
    {
        tempoDeDesativacaoAutomatica = UnityEngine.Random.Range(10, 20);
    }

    // Update is called once per frame
    void Update()
    {
        //Escudo();
        if (BossVida.vidaAtualDoBoss <= 10 && ativouEscudo == 0)
        {
            AtivarEscudo();
            ativouEscudo = 1;
        }
        if (ativouEscudo == 1)
        {
            tempoDeDesativacaoAutomatica -= Time.deltaTime;
            if(tempoDeDesativacaoAutomatica <= 0)
            {
                QuebrarEscudo();
                ativouEscudo = 0;
            }
        }
    }

    public void AtivarEscudo()
    {
        GetComponent<CapsuleCollider2D>().enabled = false;
        escudoAtivo = Instantiate(prefabDoEscudo, transform.position, transform.rotation);
        hits = UnityEngine.Random.Range(3,5);
    }

    public void QuebrarEscudo()
    {
        GetComponent<CapsuleCollider2D>().enabled = true;
        Destroy(escudoAtivo.gameObject);
    }

    public void Escudo()
    {
        hits--;
        if (hits <= 0)
        {
            QuebrarEscudo();
        }
    }

}
