using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // To access UI component in Unity

public class globalAmmo : MonoBehaviour
{
    public static int handgunAmmo;
    public GameObject ammoDisplay;

    void Update() {
        ammoDisplay.GetComponent<Text>().text = "b  " + handgunAmmo;
    }
}
