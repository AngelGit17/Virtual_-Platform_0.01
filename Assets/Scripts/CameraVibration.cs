using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraVibration : MonoBehaviour
{
    public float maxVibrationIntensity = 0.2f; 
    public float vibrationSpeed = 50f; 
    public float damping = 0.9f; 

    private Vector3 originalPosition;
    private float currentVibrationIntensity;

    void Start()
    {
        originalPosition = transform.localPosition;
        currentVibrationIntensity = 0f;
    }

    void Update()
    {
        if (currentVibrationIntensity > 0f)
        {
           
            Vector3 randomVibration = Random.insideUnitSphere * currentVibrationIntensity;
            transform.localPosition = originalPosition + randomVibration;

            
            currentVibrationIntensity *= damping;
        }
    }

   
    public void ShakeCamera()
    {
        currentVibrationIntensity = maxVibrationIntensity;
    }
}