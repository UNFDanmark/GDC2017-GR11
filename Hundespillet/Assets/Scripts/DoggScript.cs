using UnityEngine;
using System.Collections;

public class DoggScript : MonoBehaviour {
	public int horizontalRunSpeed = 6;
	public Rigidbody dogRigidbody;
	public int jumpHeight = 10;
	public KeyCode jumpButton = KeyCode.J;
	public PointsHandlerScript pointsHandler;
	public float groundDistance=0.6f;
	public AudioSource dogSound;

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
		if (Physics.Raycast (transform.position, Vector3.down, groundDistance, 1<<8)) {
			dogRigidbody.velocity = new Vector3 (dogRigidbody.velocity.x, jumpHeight, dogRigidbody.velocity.z);
		}
	}

	public void PickUp (GameObject target)
	{
		Destroy (target);

		pointsHandler.AddPoints (1);

		dogSound.PlayOneShot ("");


	}
}
