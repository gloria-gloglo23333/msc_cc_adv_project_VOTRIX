using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass8 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.4f,1.8f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
