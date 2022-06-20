using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree2 : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        sound.pitch = Random.Range(1.5f, 4.75f);

        sound.Play();

        //Debug.Log("TempleSound Playing");
    }
}
