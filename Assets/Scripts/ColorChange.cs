using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    int counter = 0;
	void Update () {
        
        if (Input.GetMouseButtonDown(0))
        {
            counter = counter + 1;
            if (counter % 2 != 0)
            {
                GetComponent<Renderer>().material.color = Color.blue;
            } else
            {
                GetComponent<Renderer>().material.color = Color.red;
            }
        }
	}
}
