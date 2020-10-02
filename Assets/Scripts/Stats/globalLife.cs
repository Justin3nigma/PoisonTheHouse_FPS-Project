using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalLife : MonoBehaviour
{

    public GameObject lifeDisplay;
    public static int lifeValue = 3;
    public int internalLife;

    // Update is called once per frame
    void Update()
    {
        internalLife = lifeValue;
        lifeDisplay.GetComponent<Text>().text = "O " + "" + lifeValue;
    }
}
