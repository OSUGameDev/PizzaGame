using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Monobehaviour{

	[SerializeField]
	private float speed;
	void Awake(){
		speed=6;
	}
	void Update(){
		speed=7;
		float x=GetComponent<Transform>().position.x;
		float y=GetComponent<Transform>().position.y;
		float z=GetComponent<Transform>().position.z;
		GetComponent<Transform>().position = new Vector3(x-(speed*Time.deltaTime),y,z);
	}
 