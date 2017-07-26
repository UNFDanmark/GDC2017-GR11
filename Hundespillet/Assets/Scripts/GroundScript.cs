using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour {
	
	DifficultyHandlerScript difficultyHandler;
	public Rigidbody groundRigidbody;
	public int moveSpeed = 10;

	// Use this for initialization

	void Start() {
		difficultyHandler = GameObject.Find ("Difficulty Handler").GetComponent<DifficultyHandlerScript> ();
	}

	void FixedUpdate () {	 
		Move (difficultyHandler.runSpeedModifier * moveSpeed);
		
	}
	public void Move (float speed){
		groundRigidbody.velocity = new Vector3 (0, 0, -speed);
	}
}
