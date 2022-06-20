using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class land3 : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        sound.pitch = Random.Range(0.75f, 1.5f);

        sound.Play();

        //Debug.Log("TempleSound Playing");
    }
}
