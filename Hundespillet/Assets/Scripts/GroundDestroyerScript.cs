using UnityEngine;
using System.Collections;

public class GroundDestroyerScript : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter (Collision collision) 
	{
		Destroy (collision.gameObject);
	}
}
