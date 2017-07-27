using UnityEngine;
using System.Collections;

public class TutorialScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= 4) {
			Destroy (gameObject);
		}
	}
}
