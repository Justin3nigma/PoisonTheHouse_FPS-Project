using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    //Following
    NavMeshAgent nav;
    GameObject target;
    public GameObject theSoldier;

    //Attack
    public string hitTag;
    public bool lookingAtPlayer = false;
    public AudioSource fireSound;
    public bool isFiring = false;
    public float fireRate = 1.5f;
    public int genHurt;
    public AudioSource[] hurtSound;
    public GameObject hurtFlash;

    //Look Player
    public Transform thePlayer;


    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("FirstPersonCharacter");

    }

    // Update is called once per frame
    void Update()
    {

        theSoldier.transform.LookAt(thePlayer); // this used to be this.transform.LookAt(thePlayer);
    

        if (nav.destination != target.transform.position)
        {
            Debug.Log("1");
            nav.SetDestination(target.transform.position);

            if (nav.remainingDistance > nav.stoppingDistance){
                Debug.Log("2");
                theSoldier.GetComponent<Animator>().Play("Walk");
            }

           else  if (nav.remainingDistance < nav.stoppingDistance){
                Debug.Log("3");
                theSoldier.GetComponent<Animator>().Play("Idle");
            }

        }

        else
        {
             nav.SetDestination(transform.position);
        }




         /*
         IEnumerator WaitUntilReachTarget(){        
          yield return new WaitForSeconds(0.025f);
          Debug.Log (nav.remainingDistance);
          yield return new WaitUntil(() => nav.remainingDistance == 0);
          Debug.Log ("ATTACK !!");*/
        }


    }
