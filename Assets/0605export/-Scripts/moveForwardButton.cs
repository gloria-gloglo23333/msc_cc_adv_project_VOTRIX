using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForwardButton : MonoBehaviour
{
	public void transCamera()
	{
		StartCoroutine(cameraMove());
	}

	IEnumerator cameraMove()
	{
		var positionZ = transform.position.z;

		while (positionZ < -180.0f)
		{
			Debug.Log(positionZ);
			transform.Translate( 0, 0, 4.0f * Time.deltaTime );
			positionZ = transform.position.z;
			yield return null;
		}
	}
}
