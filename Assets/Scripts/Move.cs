using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 Vec;
    public float hor;
    public float ver;
    public float speed = 6;
    // Update is called once per frame
    void Update()
    {
        MoverClase();
    }
    public void MoverClase()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(hor*(-1), 0, ver * (-1)) * speed * Time.deltaTime);
    }
}
