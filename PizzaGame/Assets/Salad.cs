using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salad : MonoBehaviour {

	[SerializeField]
	private float speed;
	[SerializeField]
	private float rebound;
	void Awake(){
		speed = 2;

	}
	// Update is called once per frame
	void Update () {
		speed = 3;
		float x = GetComponent<Transform>().position.x;
		float y = GetComponent<Transform>().position.y;
		float z = GetComponent<Transform>().position.z;
		if (rebound == 360) {
			rebound = 0;}
		if(rebound<=180){
			GetComponent<Transform>().position = new Vector3(x - (speed * Time.deltaTime), y, z);
				}
		if (rebound > 180) {
			GetComponent<Transform> ().position = new Vector3(x + (speed * Time.deltaTime), y, z);
		}
		rebound = rebound + 1;
	}
}
