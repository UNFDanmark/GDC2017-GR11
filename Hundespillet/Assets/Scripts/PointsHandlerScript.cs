using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PointsHandlerScript : MonoBehaviour {
	public int points = 0;
	public Text pointsText;
	public GameObject pointsHandler;
	public GameObject scoreShowerScript;
	// Use this for initialization
	void Start () {
		if(SceneManager.GetActiveScene().name=="BeachRun"){
		DontDestroyOnLoad (pointsHandler);
		}
	}
	
	// Update is called once per frame
	void Update (){
		if (SceneManager.GetActiveScene ().name == "GameOver") {
			Destroy (gameObject);
		}
	}

	public void AddPoints(int pointsAdd)
	{
		points += pointsAdd;

		pointsText.text = "Bikinier: " + points;
	}

}
