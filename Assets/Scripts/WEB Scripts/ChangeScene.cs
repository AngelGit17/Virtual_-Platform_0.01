using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public GameObject panel;
    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Reticle"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        SceneManager.LoadScene("Loading screen");
        panel.SetActive(true);
        print("hello");
        }
    }
    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "Reticle"){
        panel.SetActive(false);
        }
    }
}
