using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour {
	public KeyCode restartButton =KeyCode.Space;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(restartButton)) {
			Retry ();
		}
	}
	public void Retry()
	{
		SceneManager.LoadScene ("BeachRun");
	}
}
