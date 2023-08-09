using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakePlayer : MonoBehaviour
{
    public CameraVibration cameraVibration;

    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
           
            cameraVibration.ShakeCamera();
        }
    }
}


