using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Piso : MonoBehaviour
{
    public GameObject canvas;
          
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0)){
        print("0");
        SceneManager.LoadScene("Entrada");
        canvas.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.Alpha1)){
        print("1");
        SceneManager.LoadScene("Comedor");
        canvas.SetActive(false);


        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
        print("2");
        SceneManager.LoadScene("Planta1");
        canvas.SetActive(false);


        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
        print("3");
        SceneManager.LoadScene("Sala de juntas");
        canvas.SetActive(false);


        }
    }
}
