using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatorz : MonoBehaviour
{
    [SerializeField]private Vector3 _rotation;
    [SerializeField]public float rotateSpeed = 10f;

    void update()
    {
        if (Input.GetKey(KeyCode.A)) _rotation = Vector3.left;
        else if (Input.GetKey(KeyCode.D)) _rotation = Vector3.right;

        else _rotation = Vector3.zero;

        transform.Rotate(_rotation * rotateSpeed * Time.deltaTime);
    }
}
