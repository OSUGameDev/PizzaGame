using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


public class Hotdog : MonoBehaviour{
	private System.Random rnd= new System.Random();
	[SerializeField]
	private float speed;

	[SerializeField]
	private int frame;
	[SerializeField]
	private int jump;

	void Awake(){
		speed=3;
		System.Random rnd = new System.Random(); 
		frame=0;
	}
	void Update ()
	{
		frame++;
		if (frame == 240) {
			frame = 0;
		}
		if (frame == 120) {
			jump = rnd.Next (1, 4);
		}
		if(frame > 120){
			float x = GetComponent<Transform> ().position.x;
			float y = GetComponent<Transform> ().position.y;
			float z = GetComponent<Transform> ().position.z;
			if (jump == 1) {
				if (frame < 180) {
					GetComponent<Transform> ().position = new Vector3 (x - (speed * Time.deltaTime), y + (speed * Time.deltaTime), z);
				} else {
					GetComponent<Transform> ().position = new Vector3 (x - (speed * Time.deltaTime), y - (speed * Time.deltaTime), z);
				}
			}
			if (jump == 2) {
				if (frame < 180) {
					GetComponent<Transform> ().position = new Vector3 (x + (speed * Time.deltaTime), y + (speed * Time.deltaTime), z);
				} else {
					GetComponent<Transform> ().position = new Vector3 (x + (speed * Time.deltaTime), y - (speed * Time.deltaTime), z);
				}
			}
			if (jump == 3) {
				if (frame < 180) {
					GetComponent<Transform> ().position = new Vector3 (x, y + (speed * Time.deltaTime), z);
				} else {
					GetComponent<Transform> ().position = new Vector3 (x, y - (speed * Time.deltaTime), z);
				}
			}} 
		else {
			speed = 4;
			float x = GetComponent<Transform> ().position.x;
			float y = GetComponent<Transform> ().position.y;
			float z = GetComponent<Transform> ().position.z;
			GetComponent<Transform> ().position = new Vector3 (x - (speed * Time.deltaTime), y, z);
		}
	}
}