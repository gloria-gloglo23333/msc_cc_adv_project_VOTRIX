using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakesound1 : MonoBehaviour
{
    public AudioSource sound;
    
    private void OnTriggerEnter(Collider GameObject) 
    {
        if(GameObject.GetComponent<Collider>().tag == "fake")
        {
          sound.Play();
          Debug.Log("FakeSound Playing");   
        }
    }
}
