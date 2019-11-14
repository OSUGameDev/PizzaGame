using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Score : MonoBehaviour {
	private float timeLeft = 120;
	public int playerScore = 0;

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0.1f){
			SceneManager.LoadScene("Prototype_1");
		}		
	}
	void OnTriggerEnter2D (Collider2D trig){
		CountScore();
	}
	void CountScore(){
		playerScore = playerScore + (int)(timeLeft * 10);
	}
};
