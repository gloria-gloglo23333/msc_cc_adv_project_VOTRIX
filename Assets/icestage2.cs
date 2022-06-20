using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icestage2 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.25f, 2.25f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
