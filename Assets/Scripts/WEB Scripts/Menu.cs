using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Menu : MonoBehaviour
{
    public GameObject canvas;
          
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha4)){
        print("0");
        SceneManager.LoadScene("Incendio");
        canvas.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.Alpha5)){
        print("1");
        SceneManager.LoadScene("Sismo");
        canvas.SetActive(false);

        }
        if(Input.GetKeyDown(KeyCode.Escape)){
        SceneManager.LoadScene("Planta1");
        canvas.SetActive(false);

        }
    }
}
