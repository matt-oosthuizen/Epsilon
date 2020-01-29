using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoxController : MonoBehaviour
{
    public float jumpBoxForce = 8;
    private Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumpBoxForce, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        rb = other.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumpBoxForce / 4, ForceMode.Impulse);
    }
}
