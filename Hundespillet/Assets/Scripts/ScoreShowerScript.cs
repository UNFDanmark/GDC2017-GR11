using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreShowerScript : MonoBehaviour {
	public Text finalPointsText;
	public PointsHandlerScript pointsHandler;
	public int points;
	public bool destroyPointsHandler = false;
	// Use this for initialization
	void Awake(){
		pointsHandler = GameObject.Find("Points Handler").GetComponent<PointsHandlerScript>();
		points = pointsHandler.points;
		destroyPointsHandler = true;
	}

	void Start () {
		ShowPoints ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ShowPoints()
	{
		if (points == 1) {
			finalPointsText.text = "Du samlede " + points + " bikini";
		} else {
			finalPointsText.text = "Du samlede " + points + " bikinier";
		}
	}
}
