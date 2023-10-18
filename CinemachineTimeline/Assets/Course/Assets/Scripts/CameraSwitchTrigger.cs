using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchTrigger : MonoBehaviour
{
    [SerializeField] private int _camera;
    [SerializeField] private CameraManager _cameraManager;

    // Start is called before the first frame update
    void Start()
    {
        _cameraManager = GameObject.Find("Manager").GetComponent<CameraManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _cameraManager.ResetAllCams();
            _cameraManager.SetMasterCam(_camera);
        }
    }
}
