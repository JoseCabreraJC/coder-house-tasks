using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneLookAt : MonoBehaviour
{
    public Transform transformJugador;

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
    }
    void LookAtPlayer()
    {
        Quaternion rot = Quaternion.LookRotation(transformJugador.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime);
    }
}
