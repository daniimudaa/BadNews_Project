using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	//public ScoreSystem scoreScript;

	void Start ()
	{
	//	scoreScript = gameObject.GetComponent <ScoreSystem> ();
	}

	void Update ()
	{
		gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
		Destroy (gameObject, 5f);
	}
		
	void OnCollisionEnter (Collision coll)
	{
		if (coll.gameObject.tag == "Target")
		{
		//	scoreScript.AddScore();
			//play animation? break? stay?
			Destroy (coll.gameObject, 0.5f);
		}
	}

}
