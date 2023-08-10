using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarma : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    private float elapsed = 0f;
    int value;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start(){
        int randomNumber = Random.Range(1, 3);
        value = randomNumber;
        print(randomNumber);
    }
    void Update(){
        for (float f = 5f; f >= 0; f -= 0.1f) {
    }
    }
    void FixedUpdate()
    {
        if(value == 1){
        elapsed += Time.deltaTime;
     if (elapsed >= 5f) {
         elapsed = elapsed % 5f;
        source.PlayOneShot(clip);
     }}
     else if (value==2){
        print("no alarma");
     }
     }
}
