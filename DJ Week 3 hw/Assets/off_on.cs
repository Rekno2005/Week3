using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class off_on : MonoBehaviour {

    Light myLight;

	// Use this for initialization
	void Start () {

        myLight = GetComponent<Light>();
        //This puts the light parameters into the myLight basket
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("l"))
        {
            myLight.enabled = !myLight.enabled;
            //toggles enabled
        }
	}
}
