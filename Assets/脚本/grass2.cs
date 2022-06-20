using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass2 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(1.7f, 2.2f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
