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
	public GameObject objectivePrefab;
	public GameObject lastGroundSpawned;

	void Update()
	{
		SpawnGround ();
	}
	void Start ()
	{
		lastGroundSpawned = Instantiate (ground);

		SpawnGround ();
	}

	public void SpawnGround()
	{
		while (lastGroundSpawned.transform.position.z < maxSpawnDistance) 
		{
			GameObject newGround = Instantiate (ground);
			newGround.transform.position = new Vector3(0, 0, 30 + lastGroundSpawned.transform.position.z);
			lastGroundSpawned = newGround;

			for(int i=0; i < 4; i++)
			{
				GameObject obstacle_instance = (GameObject) Instantiate(obstacle, ground.transform.position, Quaternion.identity);

				obstacle_instance.transform.parent = lastGroundSpawned.transform;
				obstacle_instance.transform.localPosition = new Vector3(Random.Range(-0.45f,0.45f),1,Random.Range(-0.45f,0.45f));



			}
			GameObject objectivePrefab_instance = (GameObject) Instantiate(objectivePrefab, ground.transform.position, Quaternion.identity);

			objectivePrefab_instance.transform.parent = lastGroundSpawned.transform;
			objectivePrefab_instance.transform.localPosition = new Vector3(Random.Range(-0.45f,0.45f),1,Random.Range(-0.45f,0.45f));

		}
	}

	/*public void SpawnGround(){
		groundPresent = Physics.CheckSphere (spawnPoint, checkRadius);
		if (!groundPresent)
		{
			GameObject ground_instance = (GameObject)Instantiate (ground);
			ground.transform.position = spawnPoint;

			
		}
	}*/
}
