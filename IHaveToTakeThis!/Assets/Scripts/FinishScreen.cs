using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public string titleScene;
    
    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    public void TitleScreen()
    {
        SceneManager.LoadScene(titleScene, LoadSceneMode.Single);
    }
}
