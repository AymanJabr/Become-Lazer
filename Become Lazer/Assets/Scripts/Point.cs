using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
    public GameObject Pointer;
	
    float distance,alpha;
	
    public float PointerLength,PointerSpeed;
	
    int OneTime = 1;
	
	void Start () {
        Pointer = GameObject.Find("animation");
   	alpha = 0.5f ;
	}

    void Update() {
	    
        transform.Translate(PointerSpeed * Time.deltaTime, 0, 0);//move the point
        distance = Vector2.Distance(transform.position, Pointer.transform.position); 

        if ((distance > PointerLength) && (OneTime == 1))
        {
            var Pointer1 = Pointer.GetComponent("PointerAnimation") as PointerAnimation; 
            Pointer1.ins = true; //change the boolean 'ins' in PointerAnimation script 
            OneTime = 0;
        }
	    
        alpha -= 0.01f;
          GetComponent <SpriteRenderer>().color = new Color(1,1,1, alpha); // CHANGE ALPHA 
        if (alpha < 0) gameObject.SetActive(false);
    }
}
