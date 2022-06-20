using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree1 : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        sound.pitch = Random.Range(0.4f, 3.0f);

        sound.Play();

        //Debug.Log("TempleSound Playing");
    }
}
