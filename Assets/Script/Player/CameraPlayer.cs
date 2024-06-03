using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform jogador; // Referência ao transform do jogador
    public Vector3 offset;    // Deslocamento da câmera em relação ao jogador

    // LateUpdate is called once per frame, after all Update functions have been called
    void Update()
    {
        // Define a posição da câmera baseada na posição do jogador e no deslocamento
        transform.position = jogador.position + offset;
    }
}
