using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour 
{
	public float speed;

	void Start ()
	{
		speed = 0.1f;
	}
	
	void Update () 
	{
		transform.Translate (transform.right * speed);
	}
}
