using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float rotationSpeed = 10f;
    private Vector3 _rotation;
    public float rotateSpeed = 10f;

    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.Rotate(Vector3.down, XaxisRotation);
        transform.Rotate(Vector3.right, YaxisRotation);
    }

        

    void update()
    {
        if (Input.GetKeyUp(KeyCode.A)) _rotation = Vector3.up;
        else if (Input.GetKeyDown(KeyCode.D)) _rotation = Vector3.down;

        else _rotation = Vector3.zero;

        transform.Rotate(_rotation * rotateSpeed * Time.deltaTime);
    }
}
