using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunAmmoPickup : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource ammoPickupSound;
    public GameObject cube;
    public GameObject pickupDisplay;
    void OnTriggerEnter(Collider other)
    {
        fakeAmmoClip.SetActive(false);
        ammoPickupSound.Play();
        globalAmmo.handgunAmmo += 10;

        //pickup text 
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "Handgun Ammo +10";
        pickupDisplay.SetActive(true);

        cube.SetActive(false);
    
    }

}
