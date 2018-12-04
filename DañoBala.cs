using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DañoBala : MonoBehaviour {

   
    [SerializeField]
    float destroyTime = 0.5f;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
    

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        
        }
    }
}
