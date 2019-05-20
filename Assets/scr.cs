using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    void Update()
    {
        // Rotate the object around its local X axis at 1 degree per second
       transform.Rotate(Vector3.right*5);

        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * 10, Space.Self);
    }
}