using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AtaqueSeguePlayer : MonoBehaviour
{
    VidaPlayer vidaPlayer;

    public float velocidade = 2f;
    float tempoDeEspera;

    Transform player;
    Vector3 posicaoAnteriosPlayer;

    // Start is called before the first frame update
    void Start()
    {
        vidaPlayer = GetComponent<VidaPlayer>();
        player = GameObject.Find("Player").GetComponent<Transform>();
        posicaoAnteriosPlayer = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        SeguirPlayer();
    }

    void SeguirPlayer()
    {
        Vector3 movimento = new Vector3(player.position.x, player.position.y, player.position.z)* velocidade * Time.deltaTime;
        transform.Translate(movimento);
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player"))
        {
            VidaPlayer.vida--;
            Destroy(gameObject);
        }
    }
}
