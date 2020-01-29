using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallLayerController : MonoBehaviour
{
    public SphereCollider player;
    public GameObject playerCharacter;
    public Vector3 position = new Vector3(0, 0, 0);
    public Rigidbody rb;
    public GameObject jumpBoxExp;

    private void OnTriggerEnter(Collider player)
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        playerCharacter.transform.position = position;

        jumpBoxExp.SetActive(false);
    }
}
