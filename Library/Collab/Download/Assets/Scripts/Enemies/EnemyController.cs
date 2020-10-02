using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent nav;
    GameObject target;
    public GameObject theSoldier;




    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("FirstPersonCharacter");
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (nav.destination != target.transform.position)
        {
            nav.SetDestination(target.transform.position);
          
        }

        else
        {
            nav.SetDestination(transform.position);
        }

        if (nav.remainingDistance >= nav.stoppingDistance)
        {
                theSoldier.GetComponent<Animator>().Play("Walk");
         

        }
        
        if (nav.remainingDistance < nav.stoppingDistance)
        {
            if (nav.hasPath || nav.velocity.sqrMagnitude == 0f)
            {
                theSoldier.GetComponent<Animator>().Play("Idle");
            }

        }
    }
}
