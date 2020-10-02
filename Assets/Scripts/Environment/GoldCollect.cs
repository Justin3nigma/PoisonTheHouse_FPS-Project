using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCollect : MonoBehaviour
{
    public GameObject collectables; 
    public AudioSource CollectSound;
    public GameObject pickupDisplay;

    void OnTriggerEnter(Collider other)
    {
        globalScore.scoreValue += 500;
        globalComplete.treasureCount += 1;
        collectables.SetActive(false);
        CollectSound.Play(); 
        GetComponent<BoxCollider>().enabled = false;

        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "Collectables Collected";
        pickupDisplay.SetActive(true);
    }

}
