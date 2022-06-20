using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arena : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.8f, 1.7f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
