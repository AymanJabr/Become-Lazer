using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	public GameObject Cam;

	private float DistanceFromCamera;

	// Use this for initialization
	void Start () {
		Cam = GameObject.FindGameObjectWithTag ("MainCamera");

		//Gets the vertical distance from the cam, and deletes the gameobject if its more than that
		DistanceFromCamera = Mathf.Abs (transform.position.y - Cam.transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {

		if (DistanceFromCamera >= 8) {
			Destroy (gameObject);
		}
	}
}
