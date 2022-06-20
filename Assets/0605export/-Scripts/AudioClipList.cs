using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipList : MonoBehaviour
{
    public List<AudioClip> myAudioClipList = new List<AudioClip>();
    public List<float> myAudioClipPitch = new List<float>();
    public int AudioCount => myAudioClipList.Count;

    public void AddClip(AudioClip clip, float pitch = 1)
    {
        myAudioClipList.Add(clip);
        myAudioClipPitch.Add(pitch);
    }

    public void PlayClip(AudioSource source, int index = -1)
    {
        index = index == -1 ? (AudioCount - 1) : index;
        
        source.clip = myAudioClipList[index];
        source.pitch = myAudioClipPitch[index];
        source.Play();
    }
}
