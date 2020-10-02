using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FloorComplete : MonoBehaviour
{


    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;

    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(CompletedFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CompletedFloor(){

    
        //saving
        globalComplete.nextFloor += 1;
        PlayerPrefs.SetInt("SceneToLoad", globalComplete.nextFloor);
        PlayerPrefs.SetInt("LivesSaved", globalLife.lifeValue);
        PlayerPrefs.SetInt("ScoreSaved", globalScore.scoreValue);
        PlayerPrefs.SetInt("AmmoSaved", globalAmmo.handgunAmmo);


        //waiting for fading
        yield return new WaitForSeconds(2);

        

        //Activate complete panel (scoreboard) and wait for 15 seconds
        completePanel.SetActive(true);
        yield return new WaitForSeconds(7);

        //resetting each values 
        globalScore.scoreValue = 0;
        globalComplete.enemyCount = 0;
        globalComplete.treasureCount = 0;
      

        //load next scene
        SceneManager.LoadScene(globalComplete.nextFloor);
    }
}
