using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y < -7){
			Die ();
		}
	}
		void Die (){ 
			SceneManager.LoadScene("Prototype_1"); 
		}
}
