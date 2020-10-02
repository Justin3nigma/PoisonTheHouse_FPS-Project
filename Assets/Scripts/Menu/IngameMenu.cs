using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    private bool isPaused = false ;
    public GameObject Cam ;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }

            optionsMenu.gameObject.SetActive(!optionsMenu.gameObject.activeSelf);
            // if its currently true, it's gonna make it false and vise versa 
        }


       void Resume()
        {
            Time.timeScale = 1;
            
            AudioListener.pause = false;
            isPaused = false;
            optionsMenu.SetActive(true);
            Cam.SetActive(true);
            Cursor.visible = false;

        }

        void Pause()
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
            isPaused = true;
            optionsMenu.SetActive(false);
            Cam.SetActive(false);
            
            Cursor.visible = true;
        }

        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            optionsMenu.gameObject.SetActive(!optionsMenu.gameObject.activeSelf);
            // if its currently true, it's gonna make it false and vise versa 
           
        }*/
    }
}
