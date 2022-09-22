using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    public float rotationSpeed = 0.1f;
    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X")*rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y")*rotationSpeed;
        transform.RotateAround (Vector3.down, XaxisRotation);
        transform.RotateAround (Vector3.right, YaxisRotation);
    }
}
