using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] private GameObject[] cameras;
    [SerializeField] private int _cameraIndex = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_cameraIndex > cameras.Length - 1)
            _cameraIndex = 0;

        if (Input.GetKeyDown(KeyCode.R))
        _cameraIndex++;

        switch (_cameraIndex)
        {
            case 0:
                cameras[0].gameObject.SetActive(true);
                cameras[1].gameObject.SetActive(false);
                cameras[2].gameObject.SetActive(false);
                cameras[3].gameObject.SetActive(false);
                break;

            case 1:
                cameras[0].gameObject.SetActive(false);
                cameras[1].gameObject.SetActive(true);
                cameras[2].gameObject.SetActive(false);
                cameras[3].gameObject.SetActive(false);
                break;

            case 2:
                cameras[0].gameObject.SetActive(false);
                cameras[1].gameObject.SetActive(false);
                cameras[2].gameObject.SetActive(true);
                cameras[3].gameObject.SetActive(false);
                break;

            case 3:
                cameras[0].gameObject.SetActive(false);
                cameras[1].gameObject.SetActive(false);
                cameras[2].gameObject.SetActive(false);
                cameras[3].gameObject.SetActive(true);
                break;
        }
    }
}
