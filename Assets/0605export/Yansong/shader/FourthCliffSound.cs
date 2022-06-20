using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthCliffSound : MonoBehaviour
{
    public AudioSource sound;
    
    private void OnTriggerEnter(Collider other) 
    {
        sound.Play();
        //Debug.Log("FourthCliffSound Playing");   
    }
}
