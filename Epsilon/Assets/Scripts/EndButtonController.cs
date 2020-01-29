using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButtonController : MonoBehaviour
{
    public SphereCollider player;
    public Rigidbody rb;
    public GameObject panel;
    public GameObject EndButton;

    private void OnTriggerEnter(Collider player)
    {
        panel.SetActive(true);
        //finished = true;
    }
}
