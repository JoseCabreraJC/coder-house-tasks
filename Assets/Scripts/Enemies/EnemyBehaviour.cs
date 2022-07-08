using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public enum Comportamientos { follow, lookAt };

    public Comportamientos comportamientoEnemigo = Comportamientos.lookAt;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.magnitude);
        Debug.Log(transform.normalized);
    }

    // Update is called once per frame
    void Update()
    {
        switch (comportamientoEnemigo)
        {
            case Comportamientos.follow:
                Follow();
                break;
            case Comportamientos.lookAt:
                LookAt();
                break;
            default:
                break;
        }
    }
    void Follow()
    {
        // Follow the player
    }
    void LookAt()
    {
        // Look at the player
    }


}
