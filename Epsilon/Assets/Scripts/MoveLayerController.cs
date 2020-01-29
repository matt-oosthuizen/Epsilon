using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLayerController : MonoBehaviour
{
    private Rigidbody rb;

    private float t;
    private float startTime;

    public float directionX = 1;
    public float directionY = 1;
    public float directionZ = 1;
    public float changeDirection = 1;
    public float force = 1;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(3f*directionX*changeDirection*force, 3f*directionY *
            changeDirection * force, 3f*directionZ * changeDirection * force);
        rb.AddForce(move);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MoveLayerTrigger")
        {
            changeDirection = changeDirection * -1;
            Debug.Log("entered triggerboi");
        }
    }

}