using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour 
{
	public Transform bullet;
	public Texture Crosshairtex;

	public Transform target;
	public Vector3 hitpoint;

	public GameObject bullet1;

	public PlayerManager playerScript;

	void Update () 
	{
		if (playerScript.playMode)
		{
			if(Input.GetButtonDown("Fire1"))
			{
				RaycastHit hit;

				if (Physics.Raycast(target.position,target.forward, out hit)) 
				{
					hitpoint = hit.point;
					transform.LookAt(hitpoint);

					Instantiate(bullet, transform.position, transform.rotation);
		
					bullet1.transform.rotation = transform.rotation;
				}
			}
		}
	}
}
