using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject password;

    public static string Username;
    private string Password;
    private string[] Lines;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoginButton();
        }
    }

    public void LoginButton()
    {
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        String path = Application.dataPath + "/" + Username + ".txt";
        bool UN = false;
        bool PW = false;

        if(Username != "")
        {
            if(File.Exists(path))
            {
                UN = true;
                Lines = File.ReadAllLines(path);
            }
            else
            {
                Debug.LogWarning("Username does not exist.");
            }
        }
        else
        {
            Debug.LogWarning("Enter your username.");
        }
        if(Password != "" && File.Exists(path))
        {
            if(Password == Lines[1])
            {
                PW = true;
            }
            else
            {
                Debug.LogWarning("Password incorrect.");
            }
        }
        else
        {
            Debug.LogWarning("Enter your password.");
        }

        if(PW == true && UN == true)
        {
            Debug.Log("Login Successful");
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";

            SceneManager.LoadScene("Start Menu");
        }
    }
}
