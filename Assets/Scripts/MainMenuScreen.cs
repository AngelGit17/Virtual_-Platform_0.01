using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScreen : MonoBehaviour
{
    private float elapsed = 0f;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = 0.8f;
        image.color = tempColor;
    }
    void Update(){

        for (float f = 2f; f >= 0; f -= 0.1f) {
        //c.a = f;
    }
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        elapsed += Time.deltaTime;
     if (elapsed >= 3f) {
         elapsed = elapsed % 3f;
			Destroy(gameObject);
     }
    }
}
