using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomGenerator : MonoBehaviour {
	public GameObject ground;
	public int maxSpawnDistance = 75;
	public int checkRadius=15;
	public Vector3 spawnPoint{get{ return new Vector3 (0, -1, maxSpawnDistance);}}
	public bool groundPresent;
	public GameObject obstacle;
	void Update()
	{
		SpawnGround ();
	}



	public void SpawnGround(){
		groundPresent = Physics.CheckSphere (spawnPoint, checkRadius);
		if (groundPresent==false)
		{
			GameObject ground_instance = (GameObject)Instantiate (ground);
			ground.transform.position = spawnPoint;

			for(int i=0; i < 4; i++)
			{
				GameObject obstacle_instance = (GameObject) Instantiate(obstacle, ground.transform.position, Quaternion.identity);

				obstacle_instance.transform.parent = ground_instance.transform;
				obstacle_instance.transform.localPosition = new Vector3(Random.Range(-0.5f,0.5f),1,Random.Range(-0.5f,0.5f));



			}
		}
	}
}
