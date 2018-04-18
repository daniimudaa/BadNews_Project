using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour 
{
	public float sensitivityY = 3.0f;
	public float minimumY = -90.0f;
	public float maximumY = 90.0f;

	public float rotationY = 0.0f;

	private Quaternion yQuaternion;

	public PlayerManager playerScript;

	void Update () 
	{
		if (playerScript.playMode)
		{
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
		}

		rotationY = ClampAngle (rotationY, minimumY, maximumY);

		yQuaternion = Quaternion.AngleAxis (rotationY, Vector3.left);
		transform.localRotation = yQuaternion;
	}

	//clamping the min & max angles the camrea can turn
	static float ClampAngle (float angle, float min, float max)
	{
		if (angle < -360)
			angle += 360;
		
		if (angle > 360)
			angle -= 360;
		
		return Mathf.Clamp (angle, min, max);
	}
}
