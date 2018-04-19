using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
	private int score;
	public Text scoreText;

	void Start () 
	{
		scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
		score = 0;	
	}

//	void Update()
//	{
//		scoreText.text = "Score: " + score;
//	}
//
	public void AddScore ()
	{
		score += 10;
		scoreText.text = "Score: " + score;
	}

	//for every 1000 points, increase car speed
}
