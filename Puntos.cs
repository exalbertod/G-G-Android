using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour {

    int contador;
    public Text puntos;
    Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            contador = contador + 100;
            puntos.text = "SCORE: " + contador;

        }
    }

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        contador = 0;
        puntos.text = "SCORE: " + contador;
    }
}
