using UnityEngine;
using System.Collections;

public class DoggScript : MonoBehaviour {
	public int horizontalRunSpeed = 10;
	public Rigidbody dogRigidbody;
	public int jumpHeight = 10;
	public KeyCode jumpButton = KeyCode.J;
	public PointsHandlerScript pointsHandler;


	void Awake () {
		dogRigidbody = GetComponent<Rigidbody>();
	}

	void Update(){
		HorizontalMove (horizontalRunSpeed);
		if (Input.GetKeyDown(jumpButton)){
			Jump();
		}
	}

	void FixedUpdate () {

	}

	void OnTriggerEnter(Collider trigger)
	{
		PickUp (trigger.gameObject);
	}



	public void Move (float speed){
		dogRigidbody.velocity = new Vector3 (dogRigidbody.velocity.x, dogRigidbody.velocity.y, speed);
	}
	public void HorizontalMove (float speed){
		dogRigidbody.velocity = new Vector3 (Input.GetAxis("Horizontal") * speed, dogRigidbody.velocity.y, dogRigidbody.velocity.z);
	}
	public void Jump(){
		dogRigidbody.velocity = new Vector3 (dogRigidbody.velocity.x, jumpHeight, dogRigidbody.velocity.z);
	}

	public void PickUp (GameObject target)
	{
		Destroy (target);

		pointsHandler.AddPoints (1);
	}
}
