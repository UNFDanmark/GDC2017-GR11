using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public float cameraMoveModifier = 0.1f;
	public GameObject dogg;

	// Use this for initialization
	void Awake(){
		dogg = GameObject.Find ("Dogg");
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 ((dogg.transform.position.x*cameraMoveModifier)-transform.position.x, 0, 0));
	}
}
