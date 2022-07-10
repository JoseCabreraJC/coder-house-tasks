using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public enum Comportamientos { follow, lookAt };

    public Comportamientos comportamientoEnemigo = Comportamientos.lookAt;
    public Transform transformJugador;

    public float movementSpeed = 2f;


    // Update is called once per frame
    void Update()
    {
        switch (comportamientoEnemigo)
        {
            case Comportamientos.follow:
                if (CheckDistance() > 2)
                {
                    FollowPlayer();
                }
                break;
            case Comportamientos.lookAt:
                LookAtPlayer();
                break;
            default:
                break;
        }
    }
    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, transformJugador.position, Time.deltaTime * movementSpeed);
    }
    float CheckDistance()
    {
        float distance = Vector3.Distance(transform.position, transformJugador.position);
        return distance;
    }

    void LookAtPlayer()
    {
        Quaternion rot = Quaternion.LookRotation(transformJugador.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime);
    }

}
