using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Transform Player;
    Vector3 vel = Vector3.zero;
    public float Time = .15f;

    private void FixedUpdate()
    {
        Vector3 Pospla = new Vector3 (Player.position.x, Player.position.y + 2.5f, Player.position.z);
        Pospla.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, Pospla, ref vel, Time);

    }
}
