using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass6 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.6f, 2.6f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
