using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthChange : MonoBehaviour {
    int health = 100;
  

	// Use this for initialization
	void Start () 
    {
       GameObject.Find("GameOver").GetComponent<Text>().enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            health = health - 20;
            if (health < 0)
            {
                health = 0;
            }
            GameObject.Find("HealthNum").GetComponent<UnityEngine.UI.Text>().text = health.ToString();
        }

        if (health == 0)
        {
            Invoke("restartGame", 5);
            GameObject.Find("GameOver").GetComponent<Text>().enabled = true;
        }
    }

    void restartGame ()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
   
}
