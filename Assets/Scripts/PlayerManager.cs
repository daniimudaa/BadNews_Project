using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour 
{
	//pause screen
	public bool playMode = true;

	//player cam movement variables
	public float sensitivityX = 3f;
	public float rotationX = 0f;
	private Quaternion xQuaternion;

	//player variables
	public GameObject go;

	//script references
	////private PlayerStatsScript script;

	void Start () 
	{
		Cursor.visible = false;
		go = GameObject.FindGameObjectWithTag ("Player");
	//	script = go.GetComponent<PlayerStatsScript> ();
		//need to make it so when clicked on the game window it locks and centres the mouse cursor to the screen
	}
	
	void Update () 
	{
		//pauseScreen/combat mode
		if( Input.GetKeyDown(KeyCode.Tab) ) 
		{ 
			if(playMode) 
			{
				//paused
				playMode = false; 
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			} 
			else 
			{
				//unpaused
				playMode = true; 
				Cursor.lockState = CursorLockMode.Locked;
			} 
		}

		//cam rotation & speed
		if (playMode == true )
		{
			rotationX += Input.GetAxis("Mouse X") * sensitivityX;
		}

		//camera mouseLook
		xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.up);
		transform.localRotation = xQuaternion;
	}
}
