using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Zoom_Target : MonoBehaviour
{
    [SerializeField] private GameObject VC1;
    [SerializeField] private GameObject _target01;
    [SerializeField] private GameObject _target02;
    private bool _firstTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwitchTarget(); 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float FOV = VC1.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView -= 20;
            if (FOV < 10)
            {
                VC1.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = 60;
            }
        }
    }

    private void SwitchTarget()
    {
        if (_firstTarget == true)
        {
            VC1.GetComponent<CinemachineVirtualCamera>().LookAt = _target01.transform;
            _firstTarget = false;
        }
        else if (_firstTarget == false)
        {
            VC1.GetComponent<CinemachineVirtualCamera>().LookAt = _target02.transform;
            _firstTarget = true;
        }
    }
}
