using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CameraRotator : MonoBehaviour
{
    public float speed_rot;
    public float speed_trans;
    public static int levelNum = 0;
    //public Button playButton;

    private bool isAPressing = false;
    private bool isButton = false;
    private bool isWaiting = false;
    
    void Start()
    {
        levelNum += 1;
        Debug.Log(levelNum);

        //playButton = GameObject.FindWithTag("UIButton").GetComponent<Button>();

        StartCoroutine(waiter());
        
    }
    
    public void transButton()
	{
        //isButton = true;
        //transform.Translate(0, 0, speed_trans * Time.deltaTime);
        Debug.Log("Button Click Successful");
	}

    IEnumerator waiter()
    {

        if (levelNum == 1)
        {
            while (!isAPressing)
            {
                transform.Rotate(0, speed_rot * Time.deltaTime, 0);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    isAPressing = true;
                    // transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
                }
                yield return null;

            }

            var angle = transform.rotation.eulerAngles.y;
            angle = angle < 0 ? angle + 360.0f : angle;

            Debug.Log(angle);

            while (angle <= 359.0f)
            {

                transform.Rotate(0, 4.0f * speed_rot * Time.deltaTime, 0);
                angle = transform.rotation.eulerAngles.y;
                //angle = angle < 0 ? angle + 360 : angle;
                yield return null;
            }

            transform.rotation = Quaternion.AngleAxis(359, Vector3.up);

            yield return new WaitForSeconds(0.3f);

            while (true)
            {
                transform.Translate(0, 0, speed_trans * Time.deltaTime);
                yield return null;
            }

        }

        else if(levelNum == 2)
        {
            var angle = transform.rotation.eulerAngles.y;
            angle = angle < 0 ? angle + 360.0f : angle;

            GameObject.FindWithTag("UICanvas").SetActive(false);

            while (angle <= 89.0f)
            {
                //Debug.Log(angle);
                transform.Rotate(0, 2.0f * speed_rot * Time.deltaTime, 0);
                angle = transform.rotation.eulerAngles.y;
                //angle = angle < 0 ? angle + 360 : angle;
                yield return null;
            }

            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);

            yield return new WaitForSeconds(0.3f);

            while (true)
            {
                transform.Translate(0, 0, speed_trans * Time.deltaTime);
                yield return null;
            }
        }

        else if (levelNum == 3)
        {
            var angle = transform.rotation.eulerAngles.y;
            angle = angle < 0 ? angle + 360.0f : angle;

            GameObject.FindWithTag("UICanvas").SetActive(false);

            while (angle <= 179.0f)
            {
                //Debug.Log(angle);
                transform.Rotate(0, 2.0f * speed_rot * Time.deltaTime, 0);
                angle = transform.rotation.eulerAngles.y;
                //angle = angle < 0 ? angle + 360 : angle;
                yield return null;
            }

            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);

            yield return new WaitForSeconds(0.3f);

            while (true)
            {
                transform.Translate(0, 0, speed_trans * Time.deltaTime);
                yield return null;
            }
        }

        else if (levelNum == 4)
        {
            GameObject.FindWithTag("UICanvas").SetActive(false);
            var angle = transform.rotation.eulerAngles.y;
            angle = angle < 0 ? angle + 360.0f : angle;


            while (angle <= 269.0f)
            {
                //Debug.Log(angle);
                transform.Rotate(0, 2.0f * speed_rot * Time.deltaTime, 0);
                angle = transform.rotation.eulerAngles.y;
                //angle = angle < 0 ? angle + 360 : angle;
                yield return null;
            }

            transform.rotation = Quaternion.AngleAxis(270, Vector3.up);

            yield return new WaitForSeconds(0.3f);

            while (true)
            {
                transform.Translate(0, 0, speed_trans * Time.deltaTime);
                yield return null;
            }
        }
        else if (levelNum == 5)
		{
            GameObject.FindWithTag("UICanvas").SetActive(false);
            var angle = transform.rotation.eulerAngles.x;
            angle = angle < 0 ? angle + 360.0f : angle;

            while (angle <= 88.0f)
			{
                transform.Rotate(1.5f * speed_rot * Time.deltaTime, 0, 0);
                angle = transform.rotation.eulerAngles.x;
                yield return null;
            }

            yield return new WaitForSeconds(0.3f);

			while (true)
			{
                transform.Translate(0, 0, 1.5f * speed_trans * Time.deltaTime);
                yield return null;
			}
		}


    }

    

    
    
    // void Start()
    // {
    //     StartCoroutine(WaitForTrans());
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     if (!isAPressing)
    //     {
    //         transform.Rotate(0, 0.7f * speed_rot * Time.deltaTime, 0);
    //     }
    //     else
    //     {
    //         // transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
    //         if (transform.rotation != Quaternion.AngleAxis(359, Vector3.up))
    //         {
    //             transform.Rotate(0, 4 * speed_rot * Time.deltaTime, 0);
    //         }
    //         else
    //         {
    //             transform.rotation = Quaternion.AngleAxis(359, Vector3.up);
    //             transform.Translate(0,0,speed_trans * Time.deltaTime);
    //         }
    //     }
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         isAPressing = true;
    //         
    //         // transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
    //
    //     }
    //     
    // }

    private IEnumerator WaitForTrans()
    {
        if (isWaiting == true)
        {
            yield return new WaitForSeconds(4);
        }
        
    }
}
