using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// waypoint script
public class Tracker1 : MonoBehaviour
{
    public GameObject Marker;
    public GameObject WayPoint01;
    public GameObject WayPoint02;
    public GameObject WayPoint03;
    public GameObject WayPoint04;
    public GameObject WayPoint05;
    public GameObject WayPoint06;
    public GameObject WayPoint07;
    public GameObject WayPoint08;
    public GameObject WayPoint09;
    public int MarkTracker;

    //tracker moves from waypoint to next followed by ai
    void Update(){
        if (MarkTracker == 0) {
            Marker.transform.position = WayPoint01.transform.position;
        }

        if (MarkTracker == 1) {
            Marker.transform.position = WayPoint02.transform.position;
        }

        if (MarkTracker == 2) {
            Marker.transform.position = WayPoint03.transform.position;
        }   

        if (MarkTracker == 3) {
            Marker.transform.position = WayPoint04.transform.position;
        }
        if (MarkTracker == 4) {
            Marker.transform.position = WayPoint05.transform.position;
        }
    
        if (MarkTracker == 5) {
            Marker.transform.position = WayPoint06.transform.position;
        }

        if (MarkTracker == 6) {
            Marker.transform.position = WayPoint07.transform.position;
        }
        if (MarkTracker == 7) {
            Marker.transform.position = WayPoint08.transform.position;
        }
        if (MarkTracker == 8) {
            Marker.transform.position = WayPoint09.transform.position;
        }

    }

    IEnumerator OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "tag1") {              //tag1 is the ai tag
            this.GetComponent<BoxCollider> ().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 9){
                MarkTracker = 0;
            }
            yield return new WaitForSeconds (1);
            this.GetComponent<BoxCollider> ().enabled = true;
        }
    }


}
