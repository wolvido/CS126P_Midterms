﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//for starting countdown
public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject CarControls;

    void Start()
    {
        //start count
        StartCoroutine (CountStart());
    }

    IEnumerator CountStart ()
    {
        yield return new WaitForSeconds (0.5f); 
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play ();
        CountDown.SetActive (true);

        yield return new WaitForSeconds (1);
        CountDown.SetActive (false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play ();
        CountDown.SetActive (true);

        yield return new WaitForSeconds (1);
        CountDown.SetActive (false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play ();
        CountDown.SetActive (true);

        yield return new WaitForSeconds (1);
        CountDown.SetActive (false);
        GoAudio.Play ();
        CarControls.SetActive(true);

    }

}
