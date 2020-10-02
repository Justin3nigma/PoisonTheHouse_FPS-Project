using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalScore : MonoBehaviour
{

    public GameObject scoreDisplay;
    public static int scoreValue = 0;
    public int internalscore;
    public GameObject finalScore;

    // Update is called once per frame
    void Update()
    {
        internalscore = scoreValue;
        scoreDisplay.GetComponent<Text>().text = "V " + "" + scoreValue;
        finalScore.GetComponent<Text>().text = "" + scoreValue;
    }
}
