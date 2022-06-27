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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparo();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Disparo(2);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Disparo(3);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Disparo(4);
        }

    }
    public void Disparo(int bulletsNeeded = 1)
    {
        Vector3 bulletOffset = new Vector3(0 , 0, 0.25f);
        for (int i = 0; i < bulletsNeeded; i++)
        {
            Debug.Log("Pium");
            GameObject bullet = BulletsList[BulletsCreated];
            if (!bullet.activeSelf)
            {
                bullet.SetActive(true);
            }
            else
            {
                bullet.transform.position = CanionPosition.position + (bulletOffset * i);
            }
            BulletsCreated++;
            if (BulletsCreated == MaxBullets) BulletsCreated = 0;
        }
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
