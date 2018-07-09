using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class LeftShooter : MonoBehaviour {

    float x, y,deg,rad;
    float pi = 3.14159265f;
    public GameObject lazerR,lazerL;
    bool val = true;

    void Start () {
         
	}
	
	void Update () {
        gameObject.SetActive(val);
        if(gameObject.transform.position.x < 0) ChangeAngleL();


        if(gameObject.transform.position.x > 0) ChangeAngleR();







    }

    public void fire() {


        if (gameObject.transform.position.x < 0)  Instantiate(lazerL, transform.position, transform.rotation);
        if (gameObject.transform.position.x > 0)  Instantiate(lazerR, transform.position, transform.rotation);


    }

    public void ChangeAngleL() {
        x = CrossPlatformInputManager.GetAxis("lH");
        y = CrossPlatformInputManager.GetAxis("lV");
        if ((x < 0 && y > 0) || (x < 0 && y < 0))
        {
            if ((x <= -0.3f && y < 0f))
                deg = -pi / 2;
            if ((x <= 0.3f && y > 0f))
                deg = pi / 2;
        }
        else
            deg = Mathf.Atan(y / x);

        print(new Vector2(x, y));
        transform.rotation = Quaternion.EulerRotation(0f, 0f, deg);
    }

    public void ChangeAngleR()
    {
        x = -CrossPlatformInputManager.GetAxis("rH");
        y = -CrossPlatformInputManager.GetAxis("rV");
        if ((x < 0 && y > 0) || (x < 0 && y < 0))
        {
            if ((x <= -0.3f && y < 0f))
                deg = -pi / 2;
            if ((x <= 0.3f && y > 0f))
                deg = pi / 2;
        }
        else
            deg = Mathf.Atan(y / x);

        print(new Vector2(x, y));
        transform.rotation = Quaternion.EulerRotation(0f, 0f, deg);
    }





}
