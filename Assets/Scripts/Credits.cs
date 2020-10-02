using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject fadeOut;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BackToMenu());   
    }

    IEnumerator BackToMenu()
    {
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(false);

        if (Input.anyKey)
        {
            fadeOut.SetActive(true);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(1);
            
        }

        else
        {
            
            yield return new WaitForSeconds(4);
            fadeOut.SetActive(true);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(1);
        }

     
    }
}
