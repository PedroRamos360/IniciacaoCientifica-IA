using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            transform.position = new Vector3(Random.Range(-11.5f, 11.5f), Random.Range(4.50f, -2.13f), -0.06579258f);
        }
    }
}
