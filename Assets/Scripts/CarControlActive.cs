using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityStandardAssets.Vehicles.Car;



public class CarControlActive : MonoBehaviour {



    public GameObject CarControl;
    public GameObject CarControlAI1;
    public GameObject CarControlAI2;
    public GameObject CarControlAI3;
    public GameObject CarControlAI4;



    void Start() {

        CarControl.GetComponent<CarUserControl>().enabled = true;
        CarControlAI1.GetComponent<CarAIControl>().enabled = true;
        CarControlAI2.GetComponent<CarAIControl>().enabled = true;
        CarControlAI3.GetComponent<CarAIControl>().enabled = true;
        CarControlAI4.GetComponent<CarAIControl>().enabled = true;

    }

}

