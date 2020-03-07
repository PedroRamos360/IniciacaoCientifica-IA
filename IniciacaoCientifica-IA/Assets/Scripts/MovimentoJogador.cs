using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoJogador : MonoBehaviour {
    [SerializeField]
    float speed = 1f;

    void Update() {
        // Corrige a velocidade quando se movendo na diagonal
        if (Input.GetAxisRaw("Horizontal") != 0 && Input.GetAxisRaw("Vertical") != 0) {
            Vector3 movementXY = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
            transform.position += movementXY * Time.deltaTime * speed;
        } else {
            // Verifica o movimento horizontal
            Vector3 movementX = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            transform.position += movementX * Time.deltaTime * speed;

            // Verifica o movimento vertical
            Vector3 movementY = new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
            transform.position += movementY * Time.deltaTime * speed;
        }
    }
}
