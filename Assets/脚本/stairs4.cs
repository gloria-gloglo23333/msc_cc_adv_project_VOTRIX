using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairs4 : MonoBehaviour
{
   public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.7f, 2.7f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
  }
}
