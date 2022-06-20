using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairs5 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.5f, 1.7f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
