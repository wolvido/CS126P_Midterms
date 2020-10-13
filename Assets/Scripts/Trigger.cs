using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//finish line script
public class Trigger : MonoBehaviour
{
    public GameObject VictoryTrigger;
    public GameObject Victory;
    public GameObject Lose;
    public GameObject PlayAgain;


    void OnTriggerEnter (Collider collision){
        if (collision.gameObject.tag == "tag1"){
        Lose.SetActive (true);
        PlayAgain.SetActive (true);
        VictoryTrigger.SetActive(false);
        } else
        {
        Victory.SetActive (true);
        PlayAgain.SetActive (true);
        }
        
        
    }
}
