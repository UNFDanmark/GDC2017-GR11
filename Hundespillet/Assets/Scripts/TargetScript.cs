using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

	public GameObject target;
	public float rotationSpeed = 20;
	public float amplitude = 50;
	public float frequency = 2;
	public float phase =0;
	public float targetStartingY = 1.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, rotationSpeed * Time.deltaTime, 0, Space.World);
		target.transform.position = new Vector3 (target.transform.position.x, amplitude*Mathf.Cos (frequency*Time.timeSinceLevelLoad+phase)+targetStartingY, target.transform.position.z);

	}

}
