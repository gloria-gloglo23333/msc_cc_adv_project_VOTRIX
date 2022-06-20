using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCliffSound : MonoBehaviour
{
    public AudioSource sound;

    // [SerializeField] private AudioClip[] cliffSounds;
    
    private AudioClipList _audioClipScript;
    private const float PITCH_FACTOR = 1.059463f;

    private void Start()
    {
        _audioClipScript = GameObject.FindWithTag("GameManager").GetComponent<AudioClipList>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<SheepCollidor>(out var sc))
        {
            sc.MakeSound();
            Debug.Log("make sound");
        }
        else
        {
            return;
        }
        
        return;
        
        var randomPitch = Mathf.Pow(PITCH_FACTOR, Random.Range(-6, 6));
        sound.pitch = randomPitch;

        sound.Play();
        
        _audioClipScript.myAudioClipList.Add(sound.clip); // cliffSounds[Random.Range(0, cliffSounds.Length)]
        _audioClipScript.myAudioClipPitch.Add(randomPitch);
        //Debug.Log("MainCliffSound Playing");   
    }
}
