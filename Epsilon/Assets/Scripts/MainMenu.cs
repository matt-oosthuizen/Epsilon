using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    
    public void OptionsMenu()
    {
        SceneManager.LoadScene("Help Scene");
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("Level One");
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("Level Two");
    }

    public void LevelThree()
    {
        SceneManager.LoadScene("Level Three");
    }

    public void HelpScene()
    {
        SceneManager.LoadScene("Help Scene");
    }
}
