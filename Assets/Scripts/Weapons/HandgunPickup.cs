using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunPickup : MonoBehaviour
{
    public GameObject realHandgun; // Handgun on the camera
    public GameObject fakeHandgun; // Handgun on the floor
    // public GameObject cube; // Handgun on the floor
    public AudioSource handgunPickupSound;
    public GameObject pickupDisplay;
    public GameObject pistolImage;

    void OnTriggerEnter(Collider other)
    {
        pistolImage.SetActive(true); // Active real handgun
        realHandgun.SetActive(true); // Active real handgun
        fakeHandgun.SetActive(false); // Deactivate fake handgun to make it disappear
        handgunPickupSound.Play(); // Play Handgun Pickup sounds 
        // cube.SetActive(false);
        GetComponent<BoxCollider>().enabled = false;

        //pickup text 
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "Handgun Acquired";
        pickupDisplay.SetActive(true);
    }

}
