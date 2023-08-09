using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnimTrans : MonoBehaviour
{
    private float elapsed = 0f;
    // Start is called before the first frame update
    void Update()
    {
        for (float f = 2f; f >= 0; f -= 0.1f) {
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        elapsed += Time.deltaTime;
     if (elapsed >= 3f) {
         elapsed = elapsed % 3f;
			SceneManager.LoadScene("Entrada");

     }
    }
}
