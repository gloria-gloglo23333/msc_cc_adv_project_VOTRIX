using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Leap;
using Leap.Unity;
using UnityEngine.SceneManagement;
public class Rotator : MonoBehaviour
{
    [SerializeField] private LeapProvider provider;
    [SerializeField] private Transform followTarget;
    [SerializeField] private float speed = 8.0f;
    // [SerializeField] private float speedShift = 4.0f;
    [SerializeField] private float zRotateSpeed = 0.08f;
    [SerializeField] private float referenceMaxSpeed = 0.5f;
    [SerializeField] private float referenceMaxRotateSpeed = 32;
    [SerializeField] private float speedPower = 4.0f;
    [SerializeField] private float rotateSpeedPower = 1.12f;
    [SerializeField] private float rotateSmoothTime = 0.65f;
    [SerializeField] private float maxRotateSpeed = 90; 
    [SerializeField] private float angleCountZ = 0;



    private Vector3 _rotation;
    private float _zRotSpeed;
    private float _zRotSmoothVel;
    private Rigidbody _rb;

  

    private struct HandInfo
    {
        public Vector3 LastPosition;
        public Vector3 LastPalmNormal;
    }

    private Dictionary<int, HandInfo> _handDict;

    private void Start()
    {
        _handDict = new Dictionary<int, HandInfo>();
        _rb = gameObject.GetComponent<Rigidbody>();

        provider.OnFixedFrame += HandleFixedFrame;
    }

    private void HandleFixedFrame(Frame frame)
    {
        var hands = frame.Hands;

        var handsToDelete = _handDict.Keys.ToHashSet();

        float zRot = 0;

        foreach (var hand in hands)
        {
            if (handsToDelete.Contains(hand.Id)) handsToDelete.Remove(hand.Id);

            HandInfo info;
            if (_handDict.ContainsKey(hand.Id))
            {
                info = _handDict[hand.Id];
            }
            else
            {
                info = new HandInfo();
                _handDict[hand.Id] = info;

                info.LastPosition = hand.PalmPosition.ToVector3();
                info.LastPalmNormal = hand.PalmNormal.ToVector3();
            }

            var position = hand.PalmPosition.ToVector3();
            var palmNormal = hand.PalmNormal.ToVector3();
            
            if (hand.GrabStrength > 0.9f)
            {
                var velocity = (position - info.LastPosition) / Time.fixedDeltaTime;
                // velocity.z = 0;
                var velocityFactor = 1 + Mathf.Pow(velocity.magnitude / referenceMaxSpeed, speedPower);
                var xRot = velocity.x * speed * velocityFactor;
                var yRot = velocity.y * speed * velocityFactor;
                var zRotate = velocity.z * speed * velocityFactor;


                Vector3 currentRotation = followTarget.transform.eulerAngles;
                float inputInfluence = 0;
                inputInfluence += xRot;
                currentRotation.x = currentRotation.x % 360;
                if (currentRotation.x > 180) currentRotation.x -= 360f;
                //currentRotation.x = Mathf.Clamp(currentRotation.x + inputInfluence, ROTATION_MIN, ROTATION_MAX);

                //左右运动（x坐标）沿z轴转
                if (Math.Abs(angleCountZ) < 45)
                {
                    followTarget.Rotate(Vector3.back, Mathf.Clamp(xRot, -maxRotateSpeed * Time.fixedDeltaTime, maxRotateSpeed * Time.fixedDeltaTime), Space.World);
                }

                //前后上下运动（y、z坐标）沿x轴转
                followTarget.Rotate(Vector3.right, 0.5f * Mathf.Clamp(zRotate, -maxRotateSpeed * Time.fixedDeltaTime, maxRotateSpeed * Time.fixedDeltaTime)+ 0.5f * Mathf.Clamp(yRot, -maxRotateSpeed * Time.fixedDeltaTime, maxRotateSpeed * Time.fixedDeltaTime), Space.World);
                
                
            }
            else
            {
                var deltaAngle = Vector2.SignedAngle(
                    new Vector2(info.LastPalmNormal.x, info.LastPalmNormal.y),
                    new Vector2(palmNormal.x, palmNormal.y));
                var velocity = deltaAngle / Time.fixedDeltaTime;
                var velocityFactor = 1 + Mathf.Pow(Mathf.Abs(velocity) / referenceMaxRotateSpeed, rotateSpeedPower);
                zRot += velocity * velocityFactor * zRotateSpeed * Time.fixedDeltaTime;
            }
            
            info.LastPosition = position;
            info.LastPalmNormal = palmNormal;

            _handDict[hand.Id] = info;
        }

        _zRotSpeed = Mathf.SmoothDamp(_zRotSpeed, zRot, ref _zRotSmoothVel, rotateSmoothTime);
        // followTarget.Rotate(0, 0, Mathf.Clamp(_zRotSpeed, -maxRotateSpeed * Time.fixedDeltaTime, maxRotateSpeed * Time.fixedDeltaTime), Space.World);
        followTarget.Rotate(0, Mathf.Clamp(_zRotSpeed, -maxRotateSpeed * Time.fixedDeltaTime, maxRotateSpeed * Time.fixedDeltaTime), 0, Space.World);
        
        _rb.MoveRotation(followTarget.rotation);

        foreach (var id in handsToDelete)
        {
            _handDict.Remove(id);
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            // Destroy(other.gameObject);
            // other.gameObject.transform.position = new Vector3(0f, 1.6f, 0f);
            Scene scene = SceneManager.GetActiveScene();
            // SceneManager.LoadScene(scene.name);
        }
        
    }
}
