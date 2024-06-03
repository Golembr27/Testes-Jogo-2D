using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform jogador; // Refer�ncia ao transform do jogador
    public Vector3 offset;    // Deslocamento da c�mera em rela��o ao jogador

    // LateUpdate is called once per frame, after all Update functions have been called
    void Update()
    {
        // Define a posi��o da c�mera baseada na posi��o do jogador e no deslocamento
        transform.position = jogador.position + offset;
    }
}
