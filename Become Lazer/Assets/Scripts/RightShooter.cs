using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RightShooter : MonoBehaviour {

    float x, y,deg,rad;
    float pi = 3.14159265f;
    public GameObject lazer;
    bool val = true;

    void Start () {
         
	}
	
	void Update () {
        if(val == true) ChangeAngle();
        gameObject.SetActive(val);







    }

    public void fire() {
        if (val == true)
        {
            Instantiate(lazer, transform.position, transform.rotation);
            val = false;
        }
    }

    public void ChangeAngle() {
        x = -CrossPlatformInputManager.GetAxis("rH");
        y = -CrossPlatformInputManager.GetAxis("rV");
        if ((x < 0 && y > 0) || (x < 0 && y < 0))
        {
            if ((x >= 0.3f && y < 0f))
                deg = -pi / 2;
            if ((x >= 0.3f && y > 0f))
                deg = pi / 2;
        }
        else
            deg = Mathf.Atan(y / x);

        print(new Vector2(x, y));
        transform.rotation = Quaternion.EulerRotation(0f, 0f, deg);
    }





}
