using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToAngle : MonoBehaviour
{
    private bool rotating = true;
    // Update is called once per frame
    void Update()
    {
        if (rotating)
        {
            Vector3 toAngle = new Vector3(0, 0, 0);
            if (Vector3.Distance(transform.eulerAngles, toAngle) > 0.01f)
            {
                transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, toAngle, Time.deltaTime);
            }
            else
            {
                transform.eulerAngles = toAngle;
                // rotating = false;
            }
        }

    }
}
