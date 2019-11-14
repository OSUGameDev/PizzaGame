using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChange : MonoBehaviour {
    int health = 100;
  

	// Use this for initialization
	void Start () 
    {
       GameObject.Find("GameOver").GetComponent<Text>().enabled = false; //Hide the game over message
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            health = health - 20;
          //  if (health < 0)
            //{
             //   health = 0;
           // }
            GameObject.Find("HealthNum").GetComponent<UnityEngine.UI.Text>().text = health.ToString();
            //Change the text component on screen to the health number
        }

        if (health == 0)
        {
            Invoke("restartGame", 5); //Reset the game in 5 seconds
            GameObject.Find("GameOver").GetComponent<Text>().enabled = true; //Show the game over message
        }
    }

    void restartGame ()
    {
        Application.LoadLevel(Application.loadedLevel); //Reload the current level
    }
   
}
