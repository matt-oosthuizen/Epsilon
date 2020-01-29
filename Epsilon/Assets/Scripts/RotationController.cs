using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public float rotateX = 1;
    public float rotateY = 1;
    public float rotateZ = 1;

    void Update()
    {
        transform.Rotate(new Vector3(15*rotateX, 30 * rotateY, 45 * rotateZ) * Time.deltaTime);
    }
}
