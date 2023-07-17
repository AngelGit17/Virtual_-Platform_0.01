using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitboxInfo : MonoBehaviour
{
    public GameObject panel;
    public Text text1;
    string test = "";
    

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = test;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "alexa"){
        test = "Nuestros modelos de casas inteligentes cuentan con un dispositivo Alexa el cual provee a los usuarios con la opcion de control por voz de operaciones como encender la luz, o activar la alarma.";
        panel.SetActive (true);
        }

        else if(other.tag == "modem"){
        test = "Cada casa cuenta con internet de alta calidad, conectado usando fibra óptica, la cuál provee a los usuarios con una velocidad de 90 mb/s.";
        panel.SetActive (true);
        }
        
        else if(other.tag == "habitacion1"){
        test = "Cuarto 1 ";
        panel.SetActive (true);
        }
        
        else if(other.tag == "habitacion2"){
        test = "Cuarto 2";
        panel.SetActive (true);
        }
        
        else if(other.tag == "habitacionp"){
        test = "Cuarto principal";
        panel.SetActive (true);
        }
        
        else if(other.tag == "bañop"){
        test = "Baño completo parte de la habitación principal.";
        panel.SetActive (true);
        }
        
        else if(other.tag == "baño1"){
        test = "Medio baño de la primera planta de la casa.";
        panel.SetActive (true);
        }
        
        else if(other.tag == "baño2"){
        test = "Baño completo de la segunda planta de la casa.";
        panel.SetActive (true);
        }

        else if(other.tag == "cocina"){
        test = "Nuestras cocinas son modelos completos con estufas integradas, refrigerador y anaqueles para resguardar sus alimentos.";
        panel.SetActive (true);
        }

        else if(other.tag == "caja"){
        test = "Caja de fusibles.";
        panel.SetActive (true);
        }
        
        

    }
    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "alexa")
        panel.SetActive (false);
        
        if(others.tag == "modem")
        panel.SetActive (false);

        if(others.tag == "habitacion1")
        panel.SetActive (false);
        
        if(others.tag == "habitacion2")
        panel.SetActive (false);
        
        if(others.tag == "habitacionp")
        panel.SetActive (false);
        
        if(others.tag == "bañop")
        panel.SetActive (false);
        
        if(others.tag == "baño1")
        panel.SetActive (false);
        
        if(others.tag == "baño2")
        panel.SetActive (false);
        
        if(others.tag == "cocina")
        panel.SetActive (false);
        
        if(others.tag == "caja")
        panel.SetActive (false);
    }
}
