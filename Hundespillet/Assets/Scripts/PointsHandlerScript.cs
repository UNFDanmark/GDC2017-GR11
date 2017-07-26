using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PointsHandlerScript : MonoBehaviour {
	public int points = 0;
	public Text pointsText;
	// Use this for initialization
	void Start () {
	
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
