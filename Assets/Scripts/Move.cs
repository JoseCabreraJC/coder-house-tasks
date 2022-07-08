using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float hor;
    public float ver;
    public float speed = 2;
    // Update is called once per frame
    void Update()
    {
        MoverClase();
    }
    public void MoverClase()
    {
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");
        
        transform.Translate(new Vector3(hor, 0, ver ) * speed * Time.deltaTime);
    }
}
