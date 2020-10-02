using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    public GameObject soldier; // this has been added to put this scripts inside enemy AI
    public Transform thePlayer;
    void Update()
    {
        soldier.transform.LookAt(thePlayer); // this used to be this.transform.LookAt(thePlayer);
    }
}
