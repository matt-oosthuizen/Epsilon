using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HelpManager : MonoBehaviour
{
    public GameObject jumpBox;
    public GameObject redBox;
    public GameObject player;
    public GameObject activeObj;
    public Text explanationText;

    public void JumpBox()
    {
        activeObj.SetActive(false);
        jumpBox.SetActive(true);
        activeObj = jumpBox;
        explanationText.text = ("Jump Boxes give you a jump boost. Press the spacebar at" +
            " just the right moment to get an even bigger boost!");
    }

    public void RedBox()
    {
        activeObj.SetActive(false);
        redBox.SetActive(true);
        activeObj = redBox;
        explanationText.text = ("Red Boxes will kill you if you touch them. Watch out!");
    }

    public void Player()
    {
        activeObj.SetActive(false);
        player.SetActive(true);
        activeObj = player;
        explanationText.text = ("Control the player using WASD or Arrow Keys, and use the " +
            "Spacebar to jump. Don't fall off the map, or you'll restart the level!");
    }

    public void Return()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
