using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SecurityCameraManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Cameras;
    public int _currentCamera;
    public bool _canCycleCamera = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.C) && _canCycleCamera)
        {
            //check to see if our current Camera variable is greater then
            //our cameras array length if so set it to 1
            if (_currentCamera >= Cameras.Length -1) 
            { 
                _currentCamera = 1;
            }
            else
            //set increase the variable by one.
            {
                _currentCamera++;
            }
            
            SetLowCamPriorites();
            SetCurrentCamera();
        }
    }

    public void SetLowCamPriorites()
    {
        foreach (var cam in Cameras)
        {
            if (cam.GetComponent<CinemachineVirtualCamera>())
                cam.GetComponent<CinemachineVirtualCamera>().Priority = 10;
            
            if (cam.GetComponent<CinemachineBlendListCamera>())
                cam.GetComponent<CinemachineBlendListCamera>().Priority = 10;
        }
    }

    public void SetCurrentCamera()
    {
        if (Cameras[_currentCamera].GetComponent<CinemachineVirtualCamera>())
        {
            Cameras[_currentCamera].GetComponent<CinemachineVirtualCamera>().Priority = 15;
        }

        if (Cameras[_currentCamera].GetComponent<CinemachineBlendListCamera>())
        {
            Cameras[_currentCamera].GetComponent<CinemachineBlendListCamera>().Priority = 15;
        }
    }
}
