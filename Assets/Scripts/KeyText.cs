using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyText: MonoBehaviour
{

    public GameObject keyTxt;
   

    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(keyReqroutine());
      

    }

    IEnumerator keyReqroutine()
    {
        keyTxt.SetActive(true);
        keyTxt.GetComponent<Animator>().Play("keyReq");
        yield return new WaitForSeconds(1);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        keyTxt.SetActive(false);
        this.GetComponent<BoxCollider>().enabled = true; // Turning Boxcollider on
    }

}
