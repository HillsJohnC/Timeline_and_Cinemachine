using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraTrigger : MonoBehaviour
{
    [SerializeField] private CameraManager _camManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _camManager._canSwitchCams = true;
            _camManager.SetLowCamPriorities();
            _camManager._currentCamera = 1;
            _camManager.SetCurrentCamera();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _camManager._canSwitchCams = false;
            _camManager.SetLowCamPriorities();
            _camManager._currentCamera = 0;
            _camManager.SetCurrentCamera();
        }
    }
}