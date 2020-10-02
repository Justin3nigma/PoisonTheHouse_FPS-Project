using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
        globalLife.lifeValue += 1;
        this.gameObject.SetActive(false);
    }
}
