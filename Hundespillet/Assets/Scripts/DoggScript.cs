using UnityEngine;
using System.Collections;

public class DoggScript : MonoBehaviour {
	public int runSpeed = 10;
	public int horizontalRunSpeed = 10;
	public Rigidbody dogRigidbody;


	void Awake () {
		dogRigidbody = GetComponent<Rigidbody>();
	}

	void Update(){
		HorizontalMove (horizontalRunSpeed);
	}

	void FixedUpdate () {
		Move (runSpeed);
	}
	public void Move (float speed){
		dogRigidbody.velocity = new Vector3 (dogRigidbody.velocity.x, dogRigidbody.velocity.y, speed);
	}
	public void HorizontalMove (float speed){
		dogRigidbody.velocity = new Vector3 (Input.GetAxis("Horizontal") * speed, dogRigidbody.velocity.y, dogRigidbody.velocity.z);
	}
}