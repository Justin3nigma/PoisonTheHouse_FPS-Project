using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public AudioSource clickSound;
    public GameObject fadeOut;
    public GameObject fadeIn;
   

    public int loadScene;
    public int loadLives;
    public int loadScore;
    public int loadAmmo;

    void Start()
    {
        if (fadeIn.activeInHierarchy)
            fadeIn.SetActive(true);

        StartCoroutine(LateCall());
    }
    IEnumerator LateCall()
    {
        // deactivate after 2 seconds
        yield return new WaitForSeconds(2);
        fadeIn.SetActive(false);
        
    }

    public void NewGame()
    {
        StartCoroutine(NewGameRoutine());
    }

    IEnumerator NewGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(4);
    }



    public void QuitGame()
    {
        StartCoroutine(QuitGameRoutine());
    }

    IEnumerator QuitGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        Application.Quit();
    }

    public void Credits()
    {
        StartCoroutine(CreditsRoutine());
    }

    IEnumerator CreditsRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }

    public void ResetGame()
    {
        StartCoroutine(ResetGameRoutine());
    }
    IEnumerator ResetGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        PlayerPrefs.SetInt("SceneToLoad", 0); //Set 0 to Int value "SceneToLoad"
        PlayerPrefs.SetInt("LivesSaved", 0);
        PlayerPrefs.SetInt("ScoreSaved", 0);
        PlayerPrefs.SetInt("AmmoSaved", 0);
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        loadScene = PlayerPrefs.GetInt("SceneToLoad"); //Get the int value of SceneToLoad
        if (loadScene == 0)
        {
            // nothing happens
 
        }
        else
        {
            StartCoroutine(LoadGameRoutine());
        }
    }

    IEnumerator LoadGameRoutine()
    {

        loadLives = PlayerPrefs.GetInt("LivesSaved");
        loadScore = PlayerPrefs.GetInt("ScoreSaved");
        loadAmmo = PlayerPrefs.GetInt("AmmoSaved");


        clickSound.Play();
            fadeOut.SetActive(true);
            yield return new WaitForSeconds(2);


            globalComplete.nextFloor = loadScene;
            globalLife.lifeValue = loadLives;
            globalScore.scoreValue = loadScore;
            globalAmmo.handgunAmmo = loadAmmo;
            SceneManager.LoadScene(loadScene);
        
    }

}