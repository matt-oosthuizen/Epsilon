﻿using System.Collections;
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
    public GameObject endBox;
    public GameObject activeObj;
    public GameObject timerText;
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

    public void EndBox()
    {
        activeObj.SetActive(false);
        endBox.SetActive(true);
        activeObj = endBox;
        explanationText.text = ("When you touch this box, you'll complete the level." +
            "Do it as fast as you can!");
    }

    public void TimerText()
    {
        activeObj.SetActive(false);
        timerText.SetActive(true);
        activeObj = timerText;
        explanationText.text = ("The timer shows how long your current run has taken." +
            "It resets every time you die!");
    }

    public void Return()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
