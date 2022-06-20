using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lotus_leaf1 : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        sound.pitch = Random.Range(0.5f, 2.75f);

        sound.Play();

        //Debug.Log("TempleSound Playing");
    }
}
