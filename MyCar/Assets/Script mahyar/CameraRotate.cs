using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{ 
    public CinemachineVirtualCamera VirtualCamera;
    private Vector3 newOffback = new Vector3(0, 2.26f, 7.02f);
    private Vector3 defalt = new Vector3(0, 2.26f, -7.02f);
    private Vector3 R = new Vector3(8.55f, 2.26f, 0.32f);
    private Vector3 L = new Vector3(-8.55f, 2.26f, 0.32f);
    public RCC_CarControllerV3 car;
    public CinemachineBasicMultiChannelPerlin noise;

    void Start()
    {
        noise.m_AmplitudeGain = 0;
        noise = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    
    void Update()
    {
      if(car.speed <=  8)
        {
            noise.m_AmplitudeGain = 0.4f;
        }
        else
        {
            noise.m_AmplitudeGain = 0;
        }
        var transposer = VirtualCamera.GetCinemachineComponent<CinemachineTransposer>();
        if (Input.GetKey(KeyCode.J))
        {
            transposer.m_FollowOffset = newOffback;
        }
        else if(Input.GetKey(KeyCode.E))
        {
            transposer.m_FollowOffset = R;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transposer.m_FollowOffset = L;
        }
        else
        {
            transposer.m_FollowOffset = defalt;
        }
    }
}
