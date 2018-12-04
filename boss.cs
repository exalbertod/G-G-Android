using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss : MonoBehaviour {

    private int vida;

    void Start()
    {


        vida = 4;

    }
    void Update()
    {

        if (vida == 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("MainMenu");
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.tag == "Player")
        {
            
            Destroy(other.gameObject);
            SceneManager.LoadScene("MainMenu");


        }
       
        {
            if (other.gameObject.tag == "Lanza")
            {
        
                       vida = vida - 1;


            }
        }
    }
}
