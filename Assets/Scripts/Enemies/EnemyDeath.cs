using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;

    void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            theEnemy.GetComponent<Animator>().Play("Death");
            enemyAI.SetActive(false);
            globalScore.scoreValue += 100;

            //this script is for the following enmey 
            //theEnemy.GetComponent<EnemyController>().enabled = false;   // this code disables EnemyController script
            //this.GetComponent<BoxCollider>().enabled = false;           // this code prevents enemy deadbody to block the way 
            //this script is for the following enmey 
          
            //theEnemy.GetComponent<LookPlayer>().enabled = false;    
            // the above code can be used if the LookPlayer component is in Soldier and to disable it 
            globalComplete.enemyCount += 1;
            
        }
    }

}
