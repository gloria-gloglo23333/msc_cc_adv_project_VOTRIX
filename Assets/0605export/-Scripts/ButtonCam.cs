using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonCam : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool ispressed = false;
    public Camera camera;
    void Update()
    {
        if (ispressed)
        {
            camera.transform.Translate(0, 0, 1f);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
