using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecycleLevel : MonoBehaviour
{
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        globalLife.lifeValue -= 1;

        if(globalLife.lifeValue == 0)
        {
            gameOver.SetActive(true);
        }

        else
        {
            if (globalComplete.nextFloor == 4)
            {
                SceneManager.LoadScene(1);//Sample Scene
            }
            else
            {
                SceneManager.LoadScene(globalComplete.nextFloor);
            }
        }
    }

}
