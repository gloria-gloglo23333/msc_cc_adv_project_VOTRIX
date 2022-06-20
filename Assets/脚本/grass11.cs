using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass11 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.4f, 2.7f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
