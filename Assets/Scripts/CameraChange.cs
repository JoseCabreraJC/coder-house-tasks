using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject freeLookCam;
    public GameObject clearShotCam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            freeLookCam.SetActive(false);
            clearShotCam.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            clearShotCam.SetActive(false);
            freeLookCam.SetActive(true);
        }
    }
}
