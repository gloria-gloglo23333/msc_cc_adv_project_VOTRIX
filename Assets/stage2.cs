using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage2 : MonoBehaviour
{
  public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(1.5f, 3.2f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
   }
}
