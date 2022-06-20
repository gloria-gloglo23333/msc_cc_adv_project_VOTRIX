using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCliffSound : MonoBehaviour
{
    public AudioSource sound;
    
    private void OnTriggerEnter(Collider other) 
    {
        sound.Play();
        //Debug.Log("FinalCliffSound Playing");   
    }
}
