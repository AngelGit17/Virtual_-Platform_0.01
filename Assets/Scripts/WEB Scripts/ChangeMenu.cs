using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMenu : MonoBehaviour
{
    // Update is called once per frame
    public void Scene1(){
        SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
    }
}
