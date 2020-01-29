using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsManager : MonoBehaviour
{
    public void Help()
    {
        SceneManager.LoadScene("Help Scene");
    }

    public void Return()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void HighScores()
    {
        SceneManager.LoadScene("High Scores Scene");
    }

    public void Unlocks()
    {
        SceneManager.LoadScene("Unlocks Scene");
    }
}
