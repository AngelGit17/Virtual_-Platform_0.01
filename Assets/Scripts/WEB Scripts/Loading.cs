using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Loading : MonoBehaviour
{
    private float elapsed = 0f;
    
    void Update(){
        for (float f = 2f; f >= 0; f -= 0.1f) {
    }
    }

    void FixedUpdate()
    {
        elapsed += Time.deltaTime;
     if (elapsed >= 3f) {
         elapsed = elapsed % 3f;
			SceneManager.LoadScene("Planta1");

     }
    }

}
