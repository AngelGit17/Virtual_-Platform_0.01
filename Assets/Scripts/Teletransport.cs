using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransport : MonoBehaviour
{
    public Transform target;
    public GameObject player;
    // Start is called before the first frame update
    

    private void OnTriggerEnter(Collider other){
                if(other.tag == "Player"){
                print("hello");
                player.transform.position = target.transform.position;
                }
    }


}
