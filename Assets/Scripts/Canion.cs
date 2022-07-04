using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{
    public float timer;
    public float tiempoEntreBalas = 2f;
    public float tiempoDeVidaBala = 8f;

    public GameObject BulletToSpawn;
    public Transform CanionPosition;
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Debug.Log("Pium Temporizado");
            RestartTimer();
            Disparo();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScaleDuplicate();
        }
    }
    void RestartTimer()
    {
        timer = tiempoEntreBalas;
    }
    void ScaleDuplicate()
    {
        foreach (Transform child in CanionPosition.transform)
        {
            Debug.Log(child);
            child.localScale *= 2;
        }
    }
    void Disparo()
    {
        GameObject bullet = Instantiate(BulletToSpawn, CanionPosition);
        Destroy(bullet, tiempoDeVidaBala);
    }
}