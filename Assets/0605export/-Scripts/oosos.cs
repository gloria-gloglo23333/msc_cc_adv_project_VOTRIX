using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oosos : MonoBehaviour
{
    public AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        sound.Play();
        //Debug.Log("MainCliffSound Playing");   
    }
}
