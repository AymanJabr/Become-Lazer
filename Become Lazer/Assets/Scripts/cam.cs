using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {
    public float high,speed,Ywallup,Ywalldown;
     
    public GameObject wall;
	// Use this for initialization
	void Start () {
        high = transform.position.y;
        Ywallup   = wall.transform.position.y;
		Ywalldown = wall.transform.position.y;

    }
	
	// Update is called once per frame
	void Update () {


        if (transform.position.y < high)
        {
            transform.Translate(0,speed*Time.deltaTime,0);
        }
        if (transform.position.y > high)
        {
            transform.Translate(0,- speed * Time.deltaTime, 0);

        }

        if (transform.position.y > Ywallup)
        {
            Ywallup += 9.937f;
            Instantiate(wall, new Vector3(transform.position.x, Ywallup , 0.5f ), transform.rotation);
        }

		if (transform.position.y < Ywalldown)
		{
			Ywalldown -= 9.937f;
			Instantiate(wall, new Vector3(transform.position.x, Ywalldown , 0.5f ), transform.rotation);
		}


    }
}
