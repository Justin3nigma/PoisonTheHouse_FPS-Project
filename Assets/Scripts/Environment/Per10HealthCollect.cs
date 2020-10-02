using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Per10HealthCollect : MonoBehaviour
{

    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (globalHealth.healthValue >= 91)
        {
            globalHealth.healthValue = 100;
        }
        else
        {
            globalHealth.healthValue += 10;
        }
        collectSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }

}