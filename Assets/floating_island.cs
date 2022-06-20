using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating_island : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(1.5f, 3.0f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
   }
    
}
