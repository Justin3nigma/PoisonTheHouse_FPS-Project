using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunFire : MonoBehaviour{

    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool isFiring = false;
    public AudioSource emptySound;
    public float targetDistance;
    public int damageAmount = 5;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // if mouse-left is clicked
        {
            if(globalAmmo.handgunAmmo < 1)
            {
                StartCoroutine(EmptyHandgun());
               // emptySound.Play();
            }

            else
            {
                if (isFiring == false) // and it's not firing
                {
                    StartCoroutine(FiringHandgun()); // start this Coroutine
                }
            }
        }
    }

    IEnumerator EmptyHandgun() // and here is the Coroutine
    {
        theGun.GetComponent<Animator>().Play("EmptyGun");
        emptySound.Play();
        yield return new WaitForSeconds(0.175f);
        theGun.GetComponent<Animator>().Play("New State"); // and return to New State
    }

    IEnumerator FiringHandgun() // and here is the Coroutine
    {
        RaycastHit theShot;
        isFiring = true; // firing is ture
        globalAmmo.handgunAmmo -= 1;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }

        theGun.GetComponent<Animator>().Play("HandgunFire"); // play the fire animation
        muzzleFlash.SetActive(true); // active the muzzle flash
        gunFire.Play(); // and play the sound

        yield return new WaitForSeconds(0.05f); // for 0.05f seconds
        muzzleFlash.SetActive(false); // muzzle fash is deactivated
        yield return new WaitForSeconds(0.25f); // wait 0.25f sec for the whole process
        theGun.GetComponent<Animator>().Play("New State"); // and return to New State
        isFiring = false; // firing is false
    }

}
