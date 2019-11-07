/* 
 * Name: Jordyn Marshall
 * Date: 11/6/19
 * Attaching this script to a Game Object should be able to create the same game object
 * in random positions in the specified room.  
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreation : MonoBehaviour {

	//Designated the number of objects to create
	public int num_objects;

	//Designates room minimums and maximums
	public int room_x_size;
	public int room_y_size;

	//Static variable to ensure that no more than the specified objects
	//are created - prevents recursion. 
	//Starts at one because the attached object is included. 
	static int num_created = 1;

	// Use this for initialization
	void Start () {
		// Moves the current object to a random point in the room.
		Vector2 position = get_random_2D_point();
		transform.position = position;

		//If objects need to be created
		if (num_created < num_objects) {
			//Creates another object if not enough objects were created.
			Instantiate(this.gameObject, position, transform.rotation);
			num_created++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//Does nothing unless needs to
	}
	
	/* This function should be able to randomly generate an x component and a y component
	 * for the object to be created. It would use the size of the room to determine
	 * both x and y. 
	 * - Returns a 2D position vector, object's potential position. */
	public Vector2 get_random_2D_point() {
		//Randomly generate x position in room, must be within room
		int x_component = Random.Range(- room_x_size / 2, room_x_size / 2);

		//Randomly generate y position in room, must be within room
		int y_component = Random.Range(- room_y_size / 2, room_y_size / 2);

		//Create position based on this
		Vector2 position = new Vector2(x_component, y_component);

		//Return position
		return position;

	}

}