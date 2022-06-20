using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lotus_leaf3 : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        sound.pitch = Random.Range(0.8f, 3.25f);

        sound.Play();

        //Debug.Log("TempleSound Playing");
    }
}
