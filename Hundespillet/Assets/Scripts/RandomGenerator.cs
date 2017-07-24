using UnityEngine;
using System.Collections;

public class RandomGenerator : MonoBehaviour {
	public GameObject ground;
	public int maxSpawnDistance = 75;
	public int checkRadius=15;
	public Vector3 spawnPoint{get{ return new Vector3 (0, -1, maxSpawnDistance);}}
	public bool groundPresent;

	void Update()
	{
		SpawnGround ();
	}



	public void SpawnGround(){
		groundPresent = Physics.CheckSphere (spawnPoint, checkRadius);
		if (groundPresent==false)
		{
			Instantiate (ground);
			ground.transform.position = spawnPoint;
		}
	}
}
