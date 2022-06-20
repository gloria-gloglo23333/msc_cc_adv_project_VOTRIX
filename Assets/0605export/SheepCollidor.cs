using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class SheepCollidor : MonoBehaviour
{
    public float transitionTime = 1f;
    public Animator cameraTransition;

    [SerializeField] private AudioClip[] sheepSounds;
    [SerializeField] private float[] soundDistances;
    
    //public GM gameManager;
    private AudioClipList _audioClipScript;
    private static readonly int StartId = Animator.StringToHash("Start");
    private AudioSource _audioSource;

    private void Start()
    {
        _audioClipScript = GameObject.FindWithTag("GameManager").GetComponent<AudioClipList>();
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        //Debug.Log(gameObject.GetComponent<Collider>().name);
    
        if(other.GetComponent<Collider>().CompareTag("Water"))
        {
            //Destroy(GameObject.gameObject);
            this.gameObject.SetActive(false);
            FindObjectOfType<GM>().BackPosition();
        }
        
        if(other.transform.CompareTag("Switch"))
        {
            //only play first sound
            Debug.Log(_audioClipScript.myAudioClipList.Count);
            StartCoroutine(Waiter());
            //StartCoroutine(LoadLevel(0));

            
            
            //LoadNextLevel();
        }
    }

    private IEnumerator Waiter()
    {
        for (var i = 0; i < _audioClipScript.myAudioClipList.Count; i++)
        {
            //_audioClipScript.PlayClip(_audioSource, i);
            yield return new WaitForSeconds(soundDistances[i % soundDistances.Length]);
        }
        
        StartCoroutine(LoadLevel(0));
    }

    private IEnumerator LoadLevel(int levelIndex)
    {
        cameraTransition.SetTrigger(StartId);

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    public void MakeSound()
    {
        _audioClipScript.AddClip(sheepSounds[Random.Range(0, sheepSounds.Length)]);
        _audioClipScript.PlayClip(_audioSource);
    }
}
