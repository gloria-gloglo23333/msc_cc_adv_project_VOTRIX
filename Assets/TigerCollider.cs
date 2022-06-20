using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TigerCollider : MonoBehaviour
{
    public float transitionTime = 1f;
    public Animator cameraTransition;

    //private void OnTriggerEnter(Collider other)
    //public GM gameManager;

    private void OnTriggerEnter(Collider gameObject)
    {
        //Debug.Log(gameObject.GetComponent<Collider>().name);

        if (gameObject.GetComponent<Collider>().tag == "Dead")
        {
            //Destroy(GameObject.gameObject);
            this.gameObject.SetActive(false);
            FindObjectOfType<GM>().BackPosition();

        }


        if (gameObject.transform.tag == "Switch")
        {
            StartCoroutine(LoadLevel(0));
            //LoadNextLevel();
        }
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        cameraTransition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}