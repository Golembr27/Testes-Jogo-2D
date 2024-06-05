using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reator : MonoBehaviour
{
    EscudoBoss escudoBoss;

    int destruir;
    int contagem;

    private void Start()
    {
        escudoBoss = GetComponent<EscudoBoss>();
        destruir = UnityEngine.Random.Range(1, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        contagem++;
        if (collision.CompareTag("Player") && contagem == 3)
        {
            escudoBoss.QuebrarEscudo();
        }
    }
}
