using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	void Update ()
	{
		gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
		Destroy (gameObject, 5f);
	}

	void OnTriggerEnter (Collider col)
	{
		Destroy (gameObject);
	}


}
