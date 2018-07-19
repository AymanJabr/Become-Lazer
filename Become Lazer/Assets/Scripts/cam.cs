using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {
    public float high,speed,Ywall;
     
    public GameObject wall;
	// Use this for initialization
	void Start () {
        high = transform.position.y;
        Ywall = wall.transform.position.y;

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

        if (transform.position.y > Ywall)
        {
            Ywall += 9.937f;
            Instantiate(wall, new Vector3(transform.position.x, Ywall , 0.5f ), transform.rotation);
        }



    }
}
