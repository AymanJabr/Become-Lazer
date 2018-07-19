using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerR : MonoBehaviour
{
    public GameObject dt; // small part of the tail
    public GameObject cam;

    void Start()
    {
        cam = GameObject.Find("MainCamera"); // cam = MainCamera Object

		//StartCoroutine (KillLaser());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-20f * Time.deltaTime, 0));// move the lazer in x-axis 
        Instantiate(dt, transform.position, transform.rotation); // for the tail
        ChangeShooterPosition();//destroy the lazer & change the shooter position 

    }
    void ChangeShooterPosition(){


        if ((transform.position.x < -2.82f)) //when the lazer hits the walls
        {
            gameObject.SetActive(false);
            GameObject.Find("Pointer").transform.position = new Vector2(-2.8f, transform.position.y);//find the shooter and move it to the location of the collision
            var CamSc = cam.GetComponent("cam") as cam;
            CamSc.high = transform.position.y;
			Destroy (gameObject);
        }



    }

	/*IEnumerator KillLaser(){
		Debug.Log("Killing in progress");
		yield return new WaitForSeconds (1.5f);
		Destroy (gameObject);
	}*/
}
