using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
    public GameObject Pointer;
    float distance;
    public float PointerLength,PointerSpeed;
    float alpha = 0.5f; 
    int OneTime = 1;
    public MeshRenderer color;
	// Use this for initialization
	void Start () {
        Pointer = GameObject.Find("animation");
	}

    // Update is called once per frame
    void Update() {
        transform.Translate(PointerSpeed * Time.deltaTime, 0, 0);
        distance = Vector2.Distance(transform.position, Pointer.transform.position);

        if ((distance > PointerLength) && (OneTime == 1))
        {
            var Pointer1 = Pointer.GetComponent("PointerAnimation") as PointerAnimation;
            Pointer1.ins = true;
            OneTime = 0;
        }
        alpha -= 0.01f;
          GetComponent <SpriteRenderer>().color = new Color(1,1,1, alpha);
        if (alpha < 0) gameObject.SetActive(false);
    }
}
