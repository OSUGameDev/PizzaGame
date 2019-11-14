using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour{

	[SerializeField]
	private float speed;
	void Awake(){
		speed=15;
	}
	void Update ()
	{
		speed = 15;
		float x = GetComponent<Transform> ().position.x;
		float y = GetComponent<Transform> ().position.y;
		float z = GetComponent<Transform> ().position.z;
		GetComponent<Transform> ().position = new Vector3 (x - (speed * Time.deltaTime), y, z);
	}
}