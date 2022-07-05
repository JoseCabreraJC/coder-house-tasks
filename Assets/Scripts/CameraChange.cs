using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject freeLookCam;
    public GameObject clearShotCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            ChangeActiveCamera();
        }
    }
    void ChangeActiveCamera() 
    {
        if (freeLookCam.activeInHierarchy)
        {
            freeLookCam.SetActive(false);
            clearShotCam.SetActive(true);
        }
        else
        {
            clearShotCam.SetActive(false);
            freeLookCam.SetActive(true);
        }
    }

}
