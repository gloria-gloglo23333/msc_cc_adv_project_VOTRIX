using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_splash : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource sound;
    void Start()
	{

	}
    private void OnTriggerEnter(Collider other)
    {
        sound.pitch = Random.Range(1.0f, 2.0f);

        sound.Play();
        //Debug.Log(other);
        //Debug.Log("hi");
        //Debug.Log("TempleSound Playing");
    }
    

    /*public AudioSource audioSource;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Switch") //&& !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
    

    public AudioSource audioSource;
    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
    */


}
