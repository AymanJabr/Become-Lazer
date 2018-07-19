using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dt : MonoBehaviour {
    Vector2 Scale;
    int cout=0;
    int TailDensity = 5;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         Scale = transform.localScale;
        

        if (Scale.y > 0)
        {
            Scale.y -= 0.1f * Time.deltaTime;
            transform.localScale = Scale;
        }
        else gameObject.SetActive(false);
    }
}
