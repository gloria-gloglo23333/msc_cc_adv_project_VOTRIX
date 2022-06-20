using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class cubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SleepAndDestroy());
    }

    private IEnumerator SleepAndDestroy()
    {
        Debug.Log("i run");
        yield return new WaitForSeconds(3);
        Debug.Log("byebye");
        Destroy(gameObject);
    }
}
