using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreation : MonoBehaviour {

	//Designated the number of objects to create
	public int num_objects;

	public GameObject this_object;

	//Designates room minimums and maximums
	public int room_x_size;
	public int room_y_size;

	static int num_created = 1;

	// Use this for initialization
	void Start () {
		//Should create objects upon start
		if (num_created < num_objects) {
			Vector2 position = get_random_2D_point();
			Instantiate(this_object, position, transform.rotation);
			num_created++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		//Does nothing unless needs to
	}

	/* Should go through all of the functions to create a new object, as
	well as ensures that an object isn't created in another object or in an
	inconvient spot. */
	public void create_objects() {
		//bool success, collision;

		for (int i = 0; i < num_objects; i++) {
			Vector2 position = get_random_2D_point();
			Instantiate(this_object, position, transform.rotation);
/* 			success = false;

			while(!success) {
				Vector2 position = get_random_2D_point();
				//Check collison
				//collision = check_collision_with_other_objects();
				collision = false;
				//if so, create and set success to true
				if (!collision) {
					Instantiate(this_object, position, transform.rotation);
					success = true;

				}
				//Otherwise repeat
			}
*/		}
	}

	/* This function should be able to randomly generate an x component and a y component
	 * for the object to be created. It would take in the room max and min values for
	 * both x and y. 
	 * - Returns a 2D position vector, object's potential position. 
	 * COULD EDIT MAX/MIN SO ONLY ONE VARIABLE, SIZE, TO BE DIVIDED BY 2*/
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

	/* Should check if object is in another. Returns false if in another object,
	returns true otherwise. */
	public bool check_collision_with_other_objects() {
		//Check collison - must get info from unity
		return true;
	}

	/* Should check if object is close to floor. Returns flase if not, should
	return true otherwise */
	public bool check_close_to_floor() {
		//Check - must get info from unity
		return true;
	}
}
