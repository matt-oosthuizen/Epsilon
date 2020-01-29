using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed = 8;
    public float jumpForce = 8;
    private float startTime;
    private float t;
    private float timeCompleted;

    public SphereCollider col;

    public Rigidbody rb;

    public LayerMask groundLayers;

    public Text timerText;

    private bool finished;

    public GameObject redBoxExp;
    public GameObject playerMat;

    public Material standard, red, yellow;
    


    private string[] Lines;
    private string loginDetails = "";


    Renderer rend;


    private string path;

    void Start()
    {
        path = Application.dataPath + "/" + Login.Username + ".txt";
        rend = playerMat.GetComponent<Renderer>();

        Lines = File.ReadAllLines(path);

        Debug.Log(Lines[5]);
        if(Lines[5].Equals("0"))
        {
            rend.material = standard;
        }
        else if(Lines[5].Equals("1"))
        {
            rend.material = red;
        }
        else if (Lines[5].Equals("2"))
        {
            rend.material = yellow;
        }
        else
        {
            rend.material = standard;
            Debug.LogWarning("Error in selecting material");
        }

        rb = GetComponent<Rigidbody>();
        col = GetComponent <SphereCollider>();
        startTime = Time.time;
        finished = false;
        
        

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        if(IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    
        t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        if (finished == false)
        {
            timerText.text = minutes + ":" + seconds;
        }

    }

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius*.9f, groundLayers);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "FallLayer")
        {
            startTime = Time.time;
        }

        if (other.tag == "EndLevelOneZone")
        {
            redBoxExp.SetActive(false);
        }

        if (other.tag == "EndButton")
        {
            if(finished == false)
            {
                finished = true;
                timeCompleted = t;

                path = Application.dataPath + "/" + Login.Username + ".txt";

                Lines = File.ReadAllLines(path);
                if(float.Parse(Lines[SceneManager.GetActiveScene().buildIndex]) >= t || float.Parse(Lines[SceneManager.GetActiveScene().buildIndex]) == 0)
                {
                    Lines[SceneManager.GetActiveScene().buildIndex] = t.ToString();

                    //INCREMENT i IF YOU ADD ANOTHER SKIN OR LEVEL 
                    for(int i = 0;  i < 7; i++)
                    {
                        loginDetails += Lines[i] + "\n";
                    }

                    Debug.Log(loginDetails);

                    File.WriteAllText(path, loginDetails);

                    //Debug.Log(Lines[SceneManager.GetActiveScene().buildIndex]);
                }
            }

            
        }
    }
}
