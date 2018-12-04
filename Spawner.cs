using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public int belosidat;
      public GameObject proyectino;
    private Vector3 v3;



    void Start()
    {
    
        
        InvokeRepeating("Betis", 2.0f, Random.Range(3f, 5f));
    }

    // Update is called once per frame
    void Update()
    {

       
        
        v3 = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void Betis()
    {
        GameObject romualdo = Instantiate(proyectino, v3, transform.rotation);
    }

}

