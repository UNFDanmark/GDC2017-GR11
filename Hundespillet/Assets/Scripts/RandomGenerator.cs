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
	public GameObject parasolPrefab;
	public GameObject coolerPrefab;
	public GameObject objectivePrefab;
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
					for (int i = 0; i < 4; i++) {
						int randomNumber = Random.Range (1, 4);
						if (randomNumber == 1) {
							GameObject obstacle_instance = (GameObject)Instantiate (obstacle, ground.transform.position, Quaternion.identity);
							obstacle_instance.transform.parent = lastGroundSpawned.transform;
							obstacle_instance.transform.localPosition = new Vector3 (Random.Range (-0.45f, 0.45f), 1, Random.Range (-0.45f, 0.45f));
						} else if (randomNumber == 2) {
							GameObject obstacle_instance = (GameObject)Instantiate (parasolPrefab, ground.transform.position, Quaternion.identity);
							obstacle_instance.transform.parent = lastGroundSpawned.transform;
							obstacle_instance.transform.localPosition = new Vector3 (Random.Range (-0.45f, 0.45f), 1, Random.Range (-0.45f, 0.45f));
						} else {
							GameObject obstacle_instance = (GameObject)Instantiate (coolerPrefab, ground.transform.position, Quaternion.identity);
							obstacle_instance.transform.parent = lastGroundSpawned.transform;
							obstacle_instance.transform.localPosition = new Vector3 (Random.Range (-0.45f, 0.45f), 1, Random.Range (-0.45f, 0.45f));
						}
							
					}
					GameObject objectivePrefab_instance = (GameObject)Instantiate (objectivePrefab, ground.transform.position, Quaternion.identity);

					objectivePrefab_instance.transform.parent = lastGroundSpawned.transform;
					objectivePrefab_instance.transform.localPosition = new Vector3 (Random.Range (-0.45f, 0.45f), 1, Random.Range (-0.45f, 0.45f));

				} else {
					for (int i = 0; i < 2; i++) {
						int randomNumber = Random.Range (1, 4);
						if (randomNumber == 1) {
							GameObject obstacle_instance = (GameObject)Instantiate (obstacle, ground.transform.position, Quaternion.identity);
							obstacle_instance.transform.parent = lastGroundSpawned.transform;
							obstacle_instance.transform.localPosition = new Vector3 (Random.Range (-0.45f, 0.45f), 1, Random.Range (-0.45f, 0.45f));
						} else if (randomNumber == 2) {
							GameObject obstacle_instance = (GameObject)Instantiate (parasolPrefab, ground.transform.position, Quaternion.identity);
							obstacle_instance.transform.parent = lastGroundSpawned.transform;
							obstacle_instance.transform.localPosition = new Vector3 (Random.Range (-0.45f, 0.45f), 1, Random.Range (-0.45f, 0.45f));
						} else {
							GameObject obstacle_instance = (GameObject)Instantiate (coolerPrefab, ground.transform.position, Quaternion.identity);
							obstacle_instance.transform.parent = lastGroundSpawned.transform;
							obstacle_instance.transform.localPosition = new Vector3 (Random.Range (-0.45f, 0.45f), 1, Random.Range (-0.45f, 0.45f));
						}
					}
				}
				groundCount++;

			}
		}
	}
}