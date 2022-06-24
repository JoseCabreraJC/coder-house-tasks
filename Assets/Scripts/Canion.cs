using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{

    public GameObject BulletToSpawn;
    public Transform CanionPosition;

    public int MaxBullets = 4;
    public int BulletsCreated = 0;
    public List<GameObject> BulletsList;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateBullets();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.L))
        {
            Disparo();
        }
    }
    public void Disparo()
    {
        GameObject bullet = BulletsList[BulletsCreated];
        if (!bullet.activeSelf)
        {
            bullet.SetActive(true);
        }
        else
        {
            bullet.transform.position = CanionPosition.position;
        }
        BulletsCreated++;
        if (BulletsCreated == MaxBullets) BulletsCreated = 0;
    }
    public void InstantiateBullets()
    {
        for (int i = 0; i < MaxBullets; i++)
        {
            GameObject bullet = Instantiate(BulletToSpawn, CanionPosition);
            bullet.SetActive(false);
            BulletsList.Add(bullet);
        }
    }
}
