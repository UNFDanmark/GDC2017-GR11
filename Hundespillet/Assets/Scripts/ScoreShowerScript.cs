using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreShowerScript : MonoBehaviour {
	public Text finalPointsText;
	public PointsHandlerScript pointsHandler;
	// Use this for initialization
	void Awake(){
		pointsHandler = GameObject.Find("Points Handler").GetComponent<PointsHandlerScript>();
	}

	void Start () {
		ShowPoints ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ShowPoints()
	{
		finalPointsText.text = "Du samlede " + pointsHandler.points + " bikinier";
	}
}
