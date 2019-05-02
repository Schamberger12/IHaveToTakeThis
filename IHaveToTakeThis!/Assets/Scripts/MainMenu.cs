using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Canvas controls;
    public Canvas storyText;
    public Canvas storyText2;
    public GameObject buttons;
    public Canvas credits;
    public Canvas loading;

    bool activeControls = false;
    bool isStory = false;
    bool isCredits = false;
    bool isLoading = false;

    public void Awake()
    {
        buttons.SetActive(true);
        controls.gameObject.SetActive(false);
        storyText.gameObject.SetActive(false);
        storyText2.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        loading.gameObject.SetActive(false);
        isStory = false;
        isCredits = false;
        

    }

    public void PlayGame()
    {
        LoadingScreen();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void StartText()
    {
        buttons.SetActive(false);
        controls.gameObject.SetActive(false);
        storyText.gameObject.SetActive(true);
        isStory = true;
    }

    public void CreditsScreen()
    {
        buttons.SetActive(false);
        credits.gameObject.SetActive(true);
        isCredits = true;
    }

    public void NextStartText()
    {
        storyText.gameObject.SetActive(false);
        storyText2.gameObject.SetActive(true);
    }

    public void LoadingScreen()
    {
        buttons.SetActive(false);
        controls.gameObject.SetActive(false);
        storyText.gameObject.SetActive(false);
        storyText2.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        loading.gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void controlView()
    {

        buttons.SetActive(false);
        controls.gameObject.SetActive(true);
        activeControls = true;
    }

    public void Update()
    {
        if (activeControls)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                controls.gameObject.SetActive(false);
                buttons.SetActive(true);
            }
        }
        if(storyText)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Awake();
            }
        }
        if (isCredits)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Awake();
            }
        }
    }



}
