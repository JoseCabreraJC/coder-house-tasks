using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 Vec;
    public float hor;
    public float ver;
    public float moveSpeed = 10;
    public float rotationSpeed = 60;

    Vector3 initialPosition;
    // Update is called once per frame
    private void Start()
    {
        initialPosition = transform.position;
    }
    void Update()
    {
        //MoverInternet();
        MoverObjeto();
        if (transform.position.y < -10)
        {
            Respawn();
        }
    }
    public void MoverInternet()
    {
        Vec = transform.localPosition;
        Vec.y += Input.GetAxis("Jump") * Time.deltaTime * 20;
        Vec.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        Vec.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;
        transform.localPosition = Vec;
    }
    void Respawn()
    {
        transform.position = initialPosition;
    }
    public void MoverObjeto()
    {
        //si tengo un rigid body tengo que moverlo con fisicas
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");
        transform.Rotate(new Vector3(0, hor, 0) * rotationSpeed * Time.deltaTime);

        transform.Translate(new Vector3(0, 0, ver) * moveSpeed * Time.deltaTime);
    }
}
