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
        if (BossVida.vidaAtualDoBoss <= 5 && ativouEscudo == 0)
        {
            AtivarEscudo();
            ativouEscudo = 1;
        }else ativouEscudo = 0;
        if (ativouEscudo == 1)
        {
            tempoDeDesativacaoAutomatica -= Time.deltaTime;
            if(tempoDeDesativacaoAutomatica <= 0)
            {
                QuebrarEscudo();
            }
        }
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
