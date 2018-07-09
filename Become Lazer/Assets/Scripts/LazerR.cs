using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerR : MonoBehaviour {
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-10f * Time.deltaTime, 0));
        if ((transform.position.x > 2.82f))
        {
            gameObject.SetActive(false);
            GameObject.Find("LeftShooter").transform.position = gameObject.transform.position;

        }

        if ((transform.position.x < -2.82f))
        {
            gameObject.SetActive(false);
            GameObject.Find("LeftShooter").transform.position = gameObject.transform.position;
        }

    }
}