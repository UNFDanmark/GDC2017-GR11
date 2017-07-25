﻿using UnityEngine;
using System.Collections;

public class DifficultyHandlerScript : MonoBehaviour {

	public float runSpeedModifier = 1;
	public float obstacleAmountModifier = 1;
	public PointsHandlerScript pointsHandler;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		RunSpeedIncrease ();
	}

	public void RunSpeedIncrease()
	{
		runSpeedModifier = 1 + (pointsHandler.points * 10 + Time.realtimeSinceStartup) * 0.01f;
	}
}
