using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour {
	
	public int runSpeed = 10;
	public Rigidbody groundRigidbody;

	// Use this for initialization

	void Awake() {
		//groundRigidbody = GetComponent<Rigidbody>();
	
	}

	void FixedUpdate () {	 
		Move (runSpeed);
		
	}
	public void Move (float speed){
		groundRigidbody.velocity = new Vector3 (0, 0, -speed);
	}
}
