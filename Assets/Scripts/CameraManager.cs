using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour 
{
	//camera fire target
	public Transform target;

	//camera zoom distance
	public float zoomDistance = 10.0f;

	//raycasting target (shooting)
	public Vector3 trueTargetPosition;
	public float tempDistance;

	
	void Update () 
	{
		//mouseScroll to zoom in /out
		zoomDistance -= Input.GetAxis("Mouse ScrollWheel") * 5;

		//camera restrictions - minimum distance
		if (zoomDistance < 1f)
		{
			zoomDistance = 1f;
		}

		//camera restrictions - maximum distance
		if (zoomDistance > 10f)
		{
			zoomDistance = 10f;
		}


		//move camera positions on player local Z axis
		//transform.localPosition.z = -zoomDistance; - consider storing the value in a temp var
		Vector3 temp = transform.localPosition;
		temp.z = -zoomDistance;
		transform.localPosition = temp;



		RaycastHit hit;
		trueTargetPosition = target.transform.position;

		//raycasting bullets
		if (Physics.Linecast (trueTargetPosition, gameObject.transform.position, out hit)) 
		{  

			tempDistance = (Vector3.Distance (trueTargetPosition, hit.point)); 

			//bullet distance
			if (tempDistance < 1) 
			{
				tempDistance = 1;
			}

			if (tempDistance > 10) 
			{
				tempDistance = 10;
			}

			//transform.localPosition.z = -tempDistance;
			Vector3 temp1 = transform.localPosition;
			temp1.z = -tempDistance;
			transform.localPosition = temp1;
		}
	}
}
