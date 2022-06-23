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
        if (BulletsCreated < MaxBullets)
        {
            for (int i = 0; i < BulletsList.Count; i++)
            {
                if (!BulletsList[i].activeSelf)
                {
                    BulletsList[i].SetActive(true);
                    BulletsCreated++;
                    break;
                }
            }
        }
        else
        {
            for (int i = 0; i < BulletsList.Count; i++)
            {
                if (BulletsList[i].activeSelf)
                {
                    BulletsList[i].transform.position = CanionPosition.position;
                    break;
                }
            }
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
