using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    [SerializeField] private SecurityCameraManager manager;


    private void OnTriggerEnter(Collider other)
    {
        //if i enter the trigger sent the manager current camera to one
        if(other.tag == "Player")
        {
            manager.SetLowCamPriorites();
            manager._canCycleCamera = true;
            manager._currentCamera = 1;
            manager.SetCurrentCamera();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //if I leave the trigger set the manager current camera to 
        //zero or the default Third Person Camera
        if (other.tag == "Player")
        {
            manager.SetLowCamPriorites();
            manager._canCycleCamera = false;
            manager._currentCamera = 0;
            manager.SetCurrentCamera();
        }
    }
}
