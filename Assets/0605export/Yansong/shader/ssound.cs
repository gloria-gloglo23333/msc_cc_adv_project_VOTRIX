using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ssound : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // //private void OnTriggerEnter(Collider GameObject) 
    // //{
    //     //void Update()
    //  {
    //     //if(GameObject.GetComponent<Collider>().tag == "1st Cliff")
    //     {
    //         //source.clip = sounds[Random.Range(0, sounds.Length)];
    //         //source.Play();
    //     }
    //  }
    //     //source.clip = sounds[Random.Range(0, sounds.Length)];
    //     //source.Play();
    //     //Debug.Log("FinalCliffSound Playing");   
    // }

    // // Update is called once per frame
    // //void Update()
    // //{
    //     //if(GameObject.GetComponent<Collider>().tag == "1st Cliff")
    //     //{
    //         //source.clip = sounds[Random.Range(0, sounds.Length)];
    //         //source.Play();
    //     //}
    // //}
}
