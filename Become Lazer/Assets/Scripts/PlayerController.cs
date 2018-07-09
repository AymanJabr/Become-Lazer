using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D RG2D;
	public Vector2 MovingForce;
	public Transform PlayerTransform;

	private bool LeftOrRight;




	// Use this for initialization
	void Start () {
		RG2D = gameObject.GetComponent < Rigidbody2D >();
		PlayerTransform = gameObject.GetComponent<Transform> ();
		LeftOrRight = true;
	}
	
	// Update is called once per frame
	void Update () {


		//If you press the space key it adds a force towards the right or the left
		if (Input.GetKeyDown ("space")) {
			if (LeftOrRight) {
				RG2D.AddForce (MovingForce, ForceMode2D.Force);
				LeftOrRight = false;
			} else {
				RG2D.AddForce (-MovingForce, ForceMode2D.Force);
				LeftOrRight = true;
			}


		}

		//Limit the XValue of the Player
		Vector3 XValue = PlayerTransform.position;
		XValue.x = Mathf.Clamp (PlayerTransform.position.x, -2.8f,2.8f);
		PlayerTransform.position = XValue;

		if (PlayerTransform.position.x == -2.8f || PlayerTransform.position.x == 2.8f) {
			RG2D.velocity = Vector2.zero;
		}

	}
}
