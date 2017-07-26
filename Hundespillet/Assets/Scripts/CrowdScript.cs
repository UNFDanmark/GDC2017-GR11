using UnityEngine;
using System.Collections;

public class CrowdScript : MonoBehaviour {
	public GameObject crowd;
	public float amplitude = 50;
	public float frequency = 2;
	public float phase =0;
	public int crowdStartingY = 50;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CrowdMovement (amplitude, frequency, phase);
	}
	public void CrowdMovement(float amplitude, float frequency, float phase)
	{
		crowd.transform.position = new Vector3 (crowd.transform.position.x, amplitude*Mathf.Cos (frequency*Time.timeSinceLevelLoad+phase)+crowdStartingY, crowd.transform.position.z);
	}
}
