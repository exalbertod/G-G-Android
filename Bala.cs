using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

    [SerializeField]
    float destroyTime = 2f;
    

   // public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, destroyTime);
        //rb.velocity = transform.right * bulletSpeed;
    }

        

    
}
