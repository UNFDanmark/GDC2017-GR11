using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public float cameraMoveModifier = 0.1f;
	public GameObject dogg;
	public float cameraStartY=3.51f;

	// Use this for initialization
	void Awake(){
		dogg = GameObject.Find ("Dogg");
	}
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 ((dogg.transform.position.x*cameraMoveModifier)-transform.position.x,(dogg.transform.position.y*cameraMoveModifier)-transform.position.y+2.51f, 0));
	}
}
