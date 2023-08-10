using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FinalNotif : MonoBehaviour
{
    //public GameObject sign;
    public GameObject notificacion2;
    public int salida=0;


    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()

    {
    if(salida==1 && Input.GetKeyDown(KeyCode.Escape)){
		SceneManager.LoadScene("Entrada");
        }
    }
    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Flechas"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        //SceneManager.LoadScene("Loading screen");
        //sign.SetActive(true);
        notificacion2.SetActive(true);
        salida=1;
        }
    }
    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "Flechas"){
        //sign.SetActive(false);
        notificacion2.SetActive(false);
        salida=0;
        }
    }

}
