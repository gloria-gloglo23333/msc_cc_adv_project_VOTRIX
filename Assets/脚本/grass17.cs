using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass17 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.3f, 2.1f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
