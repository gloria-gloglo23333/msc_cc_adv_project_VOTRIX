using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass9 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.4f, 2.3f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
