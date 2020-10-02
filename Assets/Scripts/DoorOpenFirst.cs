using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour{

    public GameObject theDoor;
    public AudioSource doorFX;
   // Sound to be played when the Door is opened or closed

    void OnTriggerEnter(Collider other)
    {
        doorFX.Play(); //Play Sound
        theDoor.GetComponent<Animator>().Play("DoorOpen");
        // Play DoorOpen Animation
        this.GetComponent<BoxCollider>().enabled = false; // Turning Boxcollider off
        StartCoroutine(CloseDoor()); // This should be called after the door is opened
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5); // Wait 5 seconds before the door is closed
        doorFX.Play();//Play Sound
        theDoor.GetComponent<Animator>().Play("DoorClose");
        // Play CloseDoor Animation
        this.GetComponent<BoxCollider>().enabled = true; // Turning Boxcollider on
    }

}
