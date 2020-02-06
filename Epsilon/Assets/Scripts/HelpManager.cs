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
    public GameObject endBox;
    public GameObject activeObj;
    public GameObject timerText;
    public GameObject yellowPlayer;
    public GameObject movementObjects;
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
        player.SetActive(true);
        activeObj = player;
        explanationText.text = ("The timer shows how long your current run has taken." +
            "It resets every time you die!");
    }

    public void YellowPlayer()
    {
        activeObj.SetActive(false);
        yellowPlayer.SetActive(true);
        activeObj = yellowPlayer;
        explanationText.text = ("You can unlock new skins by completing levels in certain times. " +
            "Equip these skins from the Unlocks menu.");
    }

    public void Movement()
    {
        activeObj.SetActive(false);
        movementObjects.SetActive(true);
        activeObj = movementObjects;
        explanationText.text = ("Epsilon works with a physics system. Your character " +
            "has momentum and weight; use this to your advantage!");
    }

    public void SpeedRun()
    {
        activeObj.SetActive(false);
        player.SetActive(true);
        activeObj = player;
        explanationText.text = ("Finding less obvious routes can lead to completing " +
            " the level in a faster time.");
    }

    public void Usernames()
    {
        activeObj.SetActive(false);
        player.SetActive(true);
        activeObj = player;
        explanationText.text = ("Usernames must be unique.");
    }

    public void Passwords()
    {
        activeObj.SetActive(false);
        player.SetActive(true);
        activeObj = player;
        explanationText.text = ("Your password must be at least six digits long, with at least one number, one upper" +
            " and one lowercase letter.");
    }

    public void Return()
    {
        SceneManager.LoadScene("Start Menu");
    }
}
