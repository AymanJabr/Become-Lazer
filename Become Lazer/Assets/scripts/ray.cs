using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ray : MonoBehaviour {
    float x, y,deg,rad;
    float pi = 3.14159265f;
    public GameObject me;
    void Start () {
         
	}
	
	void Update () {
		x = CrossPlatformInputManager.GetAxis("H");
        y = CrossPlatformInputManager.GetAxis("V");
        if ((x < 0 && y > 0) || (x < 0 && y < 0))
        {
            if((x <= -0.3f && y < 0f))
            deg = -pi/2;
            if ((x <= 0.3f && y > 0f))
            deg = pi / 2;
        }
        else
            deg = Mathf.Atan(y / x);

        print(new Vector2(x, y));
        transform.rotation = Quaternion.EulerRotation(0f, 0f, deg );
    }


}
