using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spaghetti : MonoBehaviour{

	[SerializeField]
	private float speed;
	[SerializeField]
	private int frame;

	void Awake(){
		speed=3;
		frame=0;
	}
	void Update ()
	{
		frame++;
		if (frame == 240) {
			frame = 0;
		}
		float x = GetComponent<Transform> ().position.x;
		float y = GetComponent<Transform> ().position.y;
		float z = GetComponent<Transform> ().position.z;
		if (frame <= 60) {

			GetComponent<Transform> ().position = new Vector3 (x - (speed * Time.deltaTime), y - (speed * Time.deltaTime), z);}
		else if (frame <= 120) {
			GetComponent<Transform> ().position = new Vector3 (x - (speed * Time.deltaTime), y + (speed * Time.deltaTime), z);}
		else if (frame <= 180) {
			GetComponent<Transform> ().position = new Vector3 (x + (speed * Time.deltaTime), y + (speed * Time.deltaTime), z);}
		else {
			GetComponent<Transform> ().position = new Vector3 (x + (speed * Time.deltaTime), y - (speed * Time.deltaTime), z);}
	}
}