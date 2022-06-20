using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage3 : MonoBehaviour
{
 	 public AudioSource sound;

  private void OnTriggerEnter(Collider other) 
  { 
    sound.pitch = Random.Range(0.8f, 2.2f);
    
    sound.Play();
    
    //Debug.Log("MainCliffSound Playing");   
   }
}
