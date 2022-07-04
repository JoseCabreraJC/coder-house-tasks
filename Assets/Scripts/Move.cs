using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 Vec;
    public float hor;
    public float ver;
    public float speed = 2;
    // Update is called once per frame
    void Update()
    {
        MoverInternet();
        //MoverClase();
    }
    public void MoverInternet()
    {
        Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;
        transform.localPosition = Vec;
    }
    public void MoverClase()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(hor, 0, ver ) * speed * Time.deltaTime);
    }
}
