using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lotus_leaf4 : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        sound.pitch = Random.Range(1.0f, 2.0f);

        sound.Play();

        //Debug.Log("TempleSound Playing");
    }
}
