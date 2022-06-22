using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int objectHealth = 0;
    public Vector3 objectDirection;
    public Vector3 objectScale;
    public Vector3 objectPosition;
    public float objectSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        //transform.localScale = Vector3.one;
        //transform.position = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = objectPosition;
        //transform.localScale = objectScale;
        //transform.Translate(objectDirection * objectSpeed * Time.deltaTime);
        CurarJugador();
        DañarJugador();
    }
    public void CurarJugador()
    {
        Debug.Log("Curamos al jugador");
        objectHealth++;
    }
    public void DañarJugador()
    {
        Debug.Log("Daniamos al jugador");
        objectHealth--;
    }
    public void Reiniciar()
    {
        transform.position = new Vector3(1, 1 ,1);        
    }
}
