using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerL : MonoBehaviour {
    public GameObject dt; // small part of the tail
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(20f * Time.deltaTime, 0));// move the lazer in x-axis 
        Instantiate(dt, transform.position, transform.rotation);
    


        if ((transform.position.x > 2.82f) ) //when the lazer hits the walls
        {
            gameObject.SetActive(false);
            GameObject.Find("LeftShooter").transform.position = new Vector2( 2.8f, transform.position.y); ;//find the shooter and move it to the location of the collision
        }

        if ((transform.position.x < -2.82f)) //when the lazer hits the walls
        {
            gameObject.SetActive(false);
            GameObject.Find("LeftShooter").transform.position = new Vector2(-2.8f , transform.position.y);//find the shooter and move it to the location of the collision
        }



    }
}
