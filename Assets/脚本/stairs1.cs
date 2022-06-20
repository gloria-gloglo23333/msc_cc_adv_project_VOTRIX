using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairs1 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(1.4f, 2.3f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
