using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour 
{
	public ScoreSystem scoreScript;

	void Start()
	{
		scoreScript = GameObject.Find("Canvas").GetComponent<ScoreSystem>();
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Bullet") 
		{
			scoreScript.AddScore();
		}
	}
}
