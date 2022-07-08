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
        //Mover();
        MoverRE();
    }
    public void Mover()
    {
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");
        
        transform.Translate(new Vector3(hor, 0, ver ) * speed * Time.deltaTime);
    }
    void MoverRE()
    {
        ver = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(0, 0, ver) * speed * Time.deltaTime);
        
        hor = Input.GetAxisRaw("Horizontal");
        transform.Rotate(new Vector3(0, hor, 0) * speed * Time.deltaTime);
    }
}
