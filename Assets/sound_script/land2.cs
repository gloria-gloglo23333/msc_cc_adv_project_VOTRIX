using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class land2 : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        sound.pitch = Random.Range(1.0f, 2.5f);

        sound.Play();

        //Debug.Log("TempleSound Playing");
    }
}
