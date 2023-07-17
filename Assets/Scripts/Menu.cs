using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public Material material;
    public GameObject colors;
    public GameObject ColorP1;
    public GameObject ColorP2;
    public GameObject ColorP3;
    Color _Color = new Color(0.8018868f, 0.7484431f, 0.62411f, 1f);        
    Color _Color1 = new Color(0.5242969f, 0.7779734f, 0.8113208f, 1f);        
    Color _Color2 = new Color(0.6698113f, 0.6161001f, 0.4012549f, 1f);        
    


    // Start is called before the first frame update
    void Start()
    {
        colors.SetActive (false);
        ColorP1.GetComponent<Renderer>().material.GetColor("_Color");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (colors.active){
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "colormenu"){
        colors.SetActive (true);
        } 

        else if(other.tag == "color1"){
        material.color = _Color;
        } 
        else if(other.tag == "color2"){
        material.color = _Color1;
        } 
        else if(other.tag == "color3"){
        material.color = _Color2;
        } 
        else if(other.tag == "colorOg"){
        material.color = Color.white;
        } 

    }
    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "colormenu")
        colors.SetActive (false);
    }
}
