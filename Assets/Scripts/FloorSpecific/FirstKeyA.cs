using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKeyA : MonoBehaviour
{
    public GameObject keyUI;
    public GameObject lockedTrigger;
    public GameObject theKey;
    public GameObject keyTxtTrigger;
    
    void OnTriggerEnter(Collider other)
    {
        keyUI.SetActive(true);
        lockedTrigger.SetActive(true);
        keyTxtTrigger.SetActive(false);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        theKey.SetActive(false);
        
    }
}
