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
	public GameObject strandSaetPrefab;
	public GameObject chairPrefab;
	public GameObject objectivePrefab;
	public GameObject parasolPrefab;
	public GameObject lastGroundSpawned;
	public bool isHard = false;
	public int hardGround=6;
	public int easyGround=3;
	public int groundCount=0;
	public int noBoxDistance=90;

	void Update()
	{
		SpawnGround ();
	}
	void Start ()
	{
		lastGroundSpawned = Instantiate (ground);
		lastGroundSpawned.transform.position = new Vector3 (0, 0, 0);

		SpawnGround ();
	}

	public void SpawnGround()
	{
		while (lastGroundSpawned.transform.position.z < maxSpawnDistance) {
			GameObject newGround = Instantiate (ground);
			newGround.transform.position = new Vector3 (0, 0, 30 + lastGroundSpawned.transform.position.z);
			lastGroundSpawned = newGround;
			if (lastGroundSpawned.transform.position.z >= noBoxDistance) {
				
				if (isHard && groundCount >= hardGround) {
					isHard = !isHard;
					groundCount = 0;
				} else if (!isHard && groundCount >= easyGround) {
					isHard = !isHard;
					groundCount = 0;
				}
				if (isHard == true) {
					SpawnObstacles (4);
					GameObject objectivePrefab_instance = (GameObject)Instantiate (objectivePrefab, ground.transform.position, Quaternion.identity);

					objectivePrefab_instance.transform.parent = lastGroundSpawned.transform;
					objectivePrefab_instance.transform.localPosition = new Vector3 (Random.Range (-5, 5), 1, Random.Range (-5, 5));

				} else {
					
					SpawnObstacles (2);  
				}
				groundCount++;

			}
		}
	}
	public void SpawnObstacles(int numberOfObjects){
		for (int i = 0; i < numberOfObjects; i++) {
			int randomNumber = Random.Range (1, 4);
			GameObject objectToSpawn;
			float heightOffset;
			if (randomNumber == 1) {

				objectToSpawn = obstacle;
				heightOffset = 0.5f;

			} else if (randomNumber == 2) {

				objectToSpawn = strandSaetPrefab;
				heightOffset = 0.49f;
			} else if (randomNumber == 3) {

				objectToSpawn = chairPrefab;
				heightOffset = -0.12f;
			} else {

				objectToSpawn = parasolPrefab;
				heightOffset = 1;
			}
			GameObject obstacle_instance = (GameObject)Instantiate (objectToSpawn, ground.transform.position, objectToSpawn.transform.rotation);
			obstacle_instance.transform.parent = lastGroundSpawned.transform;
			obstacle_instance.transform.localPosition = new Vector3 (Random.Range (-5, 5), heightOffset, Random.Range (-5, 5));	
		}
	}
}