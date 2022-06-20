using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lily_land1 : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        sound.pitch = Random.Range(0.5f, 2.5f);

        sound.Play();

        //Debug.Log("TempleSound Playing");
    }
}
