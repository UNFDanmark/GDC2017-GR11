using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour {
	
	public DifficultyHandlerScript difficultyHandler;
	public Rigidbody groundRigidbody;
	public int moveSpeed = 10;

	// Use this for initialization

	void Awake() {
		//groundRigidbody = GetComponent<Rigidbody>();
	
	}

	void FixedUpdate () {	 
		Move (difficultyHandler.runSpeedModifier * moveSpeed);
		
	}
	public void Move (float speed){
		groundRigidbody.velocity = new Vector3 (0, 0, -speed);
	}
}
