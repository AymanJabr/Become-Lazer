using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerAnimation : MonoBehaviour {
    public GameObject Lpoint,Rpoint;
    public bool ins = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ins == true)
        {
            Instantiate(Lpoint,transform.position,transform.rotation);
            Instantiate(Rpoint, transform.position, transform.rotation);

            ins = false;

			//Destroy (Lpoint);
			//Destroy (Rpoint);
        }


    }
}
