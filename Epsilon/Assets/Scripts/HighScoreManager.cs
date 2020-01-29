using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoreManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreTextOne, highScoreTextTwo, highScoreTextThree;
    private string[] Lines;
    private string path;

    void Start()
    {
        path = Application.dataPath + "/" + Login.Username + ".txt";
        Lines = File.ReadAllLines(path);

        if(float.Parse(Lines[2]) != 0)
        {
            string minutes = ((int)(float.Parse(Lines[2])) / 60).ToString();
            string seconds = (float.Parse(Lines[2]) % 60).ToString("f2");

            highScoreTextOne.text = minutes + ":" + seconds;
        }
        else
        {
            highScoreTextOne.text = "Not completed";
        }

        if (float.Parse(Lines[3]) != 0)
        {
            string minutes = ((int)(float.Parse(Lines[3])) / 60).ToString();
            string seconds = (float.Parse(Lines[3]) % 60).ToString("f2");

            highScoreTextTwo.text = minutes + ":" + seconds; 
        }
        else
        {
            highScoreTextTwo.text = "Not completed";
        }

        if (float.Parse(Lines[4]) != 0)
        {
            string minutes = ((int)(float.Parse(Lines[4])) / 60).ToString();
            string seconds = (float.Parse(Lines[4]) % 60).ToString("f2");

            highScoreTextThree.text = minutes + ":" + seconds;
        }
        else
        {
            highScoreTextThree.text = "Not completed";
        }
    }

    public void Return()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
