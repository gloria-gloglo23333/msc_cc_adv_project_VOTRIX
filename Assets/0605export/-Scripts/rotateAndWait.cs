using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAndWait : MonoBehaviour
{
    [SerializeField]
    private float _rotationTime = 2f;
    [SerializeField]
    private float _delayBetweenRotations = 1f;
 
    private WaitForSeconds _rotationDelay;
    private Quaternion _targetRot;
 
    private bool _rotating;
 
    private void Start()
    {
        _rotationDelay = new WaitForSeconds(_delayBetweenRotations);
        _targetRot = transform.localRotation;
    }
 
    private void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) && !_rotating)
        {
            _rotating = true;
 
            StartCoroutine(Rotate(_rotationTime));
        }
    }
 
    private IEnumerator Rotate(float rotateTime)
    {
        var startRot = transform.localRotation;
        _targetRot *= Quaternion.AngleAxis(90, Vector3.back);
 
        var time = 0f;
 
        while (time <= 1f)
        {
            transform.localRotation = Quaternion.Lerp(startRot, _targetRot, time);
            time += Time.deltaTime / rotateTime;
            yield return null;
        }
 
        transform.localRotation = _targetRot;
 
        yield return _rotationDelay;
 
        _rotating = false;
    }
}
