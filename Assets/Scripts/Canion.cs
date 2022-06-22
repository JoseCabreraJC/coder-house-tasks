using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{

    public GameObject BulletToSpawn;
    public Transform CanionPosition;

    // Start is called before the first frame update
    void Start()
    {
        Disparo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Disparo()
    {
        Instantiate(BulletToSpawn, CanionPosition);
    }
}
