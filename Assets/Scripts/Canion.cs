using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{

    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Disparo();
    }

    // Update is called once per frame
    void Update()
    {
        // nada por ahora
    }
    public void Disparo()
    {
        Instantiate(objectToSpawn, transform);
    }
}
