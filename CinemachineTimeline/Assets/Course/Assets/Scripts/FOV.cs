using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//1
using Cinemachine;

public class FOV : MonoBehaviour
{
    //2
    private CinemachineVirtualCamera _cam;
    // Start is called before the first frame update
    void Start()
    {
        //3
        _cam = GetComponent<CinemachineVirtualCamera>();
        _cam.m_Lens.FieldOfView = 40;
        
    }    
}
