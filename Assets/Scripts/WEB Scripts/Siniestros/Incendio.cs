using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Incendio : MonoBehaviour
{
    public GameObject text0;
    public GameObject text1;
    public GameObject panel;
    public GameObject notificacion;
    public int changetext =0;
    private float elapsed = 0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (float f = 10f; f >= 0; f -= 0.1f) {
    }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
        text0.SetActive (true);
        text1.SetActive (false);
        changetext = 1;
        print(changetext);
        

        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow)){
        text1.SetActive (true);
        text0.SetActive (false);
        changetext = 0;
        print(changetext);

        }
        
        
    }
    void FixedUpdate()
    {
        elapsed += Time.deltaTime;
     if (elapsed >= 4f) {
         elapsed = elapsed % 4f;
        panel.SetActive(false);
        notificacion.SetActive(true);
     }
    }
}
