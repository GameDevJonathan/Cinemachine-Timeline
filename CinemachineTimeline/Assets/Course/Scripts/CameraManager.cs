using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _cameras;


    public void SetMasterCam(int targetCam)
    {
        _cameras[targetCam].GetComponent<CinemachineVirtualCamera>().Priority = 15;
    }

    public void ResetAllCams()
    {
        foreach  (GameObject cam in _cameras)
        {
            cam.GetComponent<CinemachineVirtualCamera>().Priority = 10;
        }

    }


}


