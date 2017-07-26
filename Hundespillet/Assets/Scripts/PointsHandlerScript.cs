using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PointsHandlerScript : MonoBehaviour {
	public int points = 0;
	public Text pointsText;
	public GameObject pointsHandler;
	// Use this for initialization
	void Start () {
		if(SceneManager.GetActiveScene="BeachRun"){
		DontDestroyOnLoad (pointsHandler);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddPoints(int pointsAdd)
	{
		points += pointsAdd;

		pointsText.text = "Bikinier: " + points;
	}

}
