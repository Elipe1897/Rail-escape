using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Leo N
public class CamRotate : MonoBehaviour
{
    int _rotationSpeed = 30;

    void Update()
    {

        // Rotation on y axis
        // be sure to capitalize Rotate or you'll get errors
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }
}
