using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnlocksManager : MonoBehaviour
{
    public GameObject activePlayer;
    public Material red;
    public Material yellow;
    public Material standard;
    public Material selectedMat;
    public static Material equipedMat;

    public TextMeshProUGUI requirements;
    public Button equipButton;

    Renderer rend;

    private string loginDetails = "";
    private string path;
    private string[] Lines;

    public int mat;

    private void Start()
    {
        rend = activePlayer.GetComponent<Renderer>();
        path = Application.dataPath + "/" + Login.Username + ".txt";
        Lines = File.ReadAllLines(path);
        selectedMat = standard;
        equipedMat = standard;
    }

    public void StandardPlayer()
    {
        rend.material = standard;
        requirements.text = "Default skin";
        selectedMat = standard;
        equipButton.interactable = true;
        mat = 0;
    }

    public void RedPlayer()
    {
        rend.material = red;
        requirements.text = "Requirements: " + "\n" + "Complete Level 1 in under 60 seconds";
        selectedMat = red;
        mat = 1;

        if(float.Parse(Lines[2]) < 60 && float.Parse(Lines[2]) != 0)
        {
            equipButton.interactable = true;
        }
    }

    public void YellowPlayer()
    {
        rend.material = yellow;
        requirements.text = "Requirements: " + "\n" + "Complete Level 2 in under 3 minutes";
        selectedMat = yellow;
        mat = 2;
        if (float.Parse(Lines[2]) < 180 && float.Parse(Lines[2]) != 0)
        {
            equipButton.interactable = true;
        }
    }

    public void Return()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void Equip()
    {
        equipedMat = selectedMat;

        Lines[5] = mat.ToString();

        //INCREMENT i IF YOU ADD ANOTHER SKIN OR LEVEL
        for (int i = 0; i < 6; i++)
        {
            loginDetails += Lines[i] + "\n";
        }

        Debug.Log(loginDetails);

        File.WriteAllText(path, loginDetails);

        Debug.Log("Equipped");
    }
}
