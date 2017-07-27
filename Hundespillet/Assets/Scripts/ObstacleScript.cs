using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ObstacleScript : MonoBehaviour {
	void Awake(){
	}
	

	public void OnCollisionEnter (Collision collision) {
		if(collision.collider.CompareTag("Obstacle"))
		{
			GameOver ();
			}
		}
		public void GameOver()
		{

			SceneManager.LoadScene("GameOver");
		}
}