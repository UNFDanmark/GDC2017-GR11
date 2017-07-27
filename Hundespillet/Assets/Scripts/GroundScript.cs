using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour {
	
	DifficultyHandlerScript difficultyHandler;
	public float moveSpeed = 20f;

	// Use this for initialization

	void Start() {
		difficultyHandler = GameObject.Find ("Difficulty Handler").GetComponent<DifficultyHandlerScript> ();
	}

	void FixedUpdate () {	 
		Move (difficultyHandler.runSpeedModifier * moveSpeed);
		if (transform.position.z <= -50) {
			Destroy (gameObject);
		}
		
	}
	public void Move (float speed){
		transform.Translate(new Vector3 (0, 0, -speed));
	}
}
