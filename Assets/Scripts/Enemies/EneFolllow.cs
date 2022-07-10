using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneFolllow : MonoBehaviour
{
    public Transform transformJugador;
    public float movementSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        if (CheckDistance() > 2)
        {
            FollowPlayer();
        }
    }
    float CheckDistance()
    {
        float distance = Vector3.Distance(transform.position, transformJugador.position);
        return distance;
    }

    void FollowPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, transformJugador.position, Time.deltaTime * movementSpeed);
        // Follow the player
    }

}
