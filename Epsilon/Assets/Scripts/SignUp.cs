using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Linq;

public class SignUp : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    public GameObject confirmPassword;

    protected string Username;
    private string Password;
    private string ConfirmPassword;
    private string loginDetails;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
            if (password.GetComponent<InputField>().isFocused)
            {
                confirmPassword.GetComponent<InputField>().Select();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(Username != "" && Password != "" && ConfirmPassword != "" )
            {
                RegisterButton();
            }
        }

        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        ConfirmPassword = confirmPassword.GetComponent<InputField>().text;
    }

    public void RegisterButton()
    {
        bool UN = false;
        bool PW = false;
        bool CPW = false;
        String path = Application.dataPath + "/" + Username + ".txt";


        if (!File.Exists(path))
        {
            UN = true;
        }
        else
        {
            Debug.LogWarning("Username taken.");
        }

        if (Username == "")
        {
            Debug.LogWarning("Enter a username.");
        }
        else
        {
            UN = true;
        }

        if(Password == "")
        {
            Debug.LogWarning("Enter a password.");
        }
        else if (Password.Length < 5 || Password.Length > 16)
        {
            Debug.LogWarning("Password must be at between 6 and 16 characters long.");
        }

        else if (!Password.Any(char.IsUpper))
        {
            Debug.LogWarning("Password must contain an uppercase letter.");
        }
        else if (!Password.Any(char.IsLower))
        {
            Debug.LogWarning("Password must contain a lowercase letter.");
        }
        else if (!Password.Any(char.IsDigit))
        {
            Debug.LogWarning("Password must contain a number.");
        }
        else
        {
            PW = true;
        }


        if (ConfirmPassword == "")
        {
            Debug.LogWarning("Confirm your password.");
        }

        else if (ConfirmPassword != Password)
        {
            Debug.LogWarning("Password must be entered identically.");
        }
        else
        {
            CPW = true;
        }

        if (UN == true && PW == true && CPW == true)
        {
            loginDetails = Username + "\n" + Password + "\n" + "0" + "\n" + "0" + "\n" + "0" + "\n" + "0";

            //write to text file
            File.WriteAllText(path, loginDetails);

            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            confirmPassword.GetComponent<InputField>().text = "";
            Debug.Log("Registration complete.");
        }
    }
}
