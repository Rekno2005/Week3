using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAndDestroy : MonoBehaviour {

    //THIS WON'T WORK UNTIL YOU MAKE A THING THAT IS ACTUALLY THE PRODUCEABLE THIGN THING THGIUNDH;SGDF

    public Rigidbody projectile;
    public int instantiateIndex;
    public int destroyIndex;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("c"))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);
            clone.name = "roundboy" + instantiateIndex;
            instantiateIndex++;
        }

        if (Input.GetKeyDown("v"))
        {
            GameObject destroyable;
            destroyable = GameObject.Find("roundboi" + destroyIndex);
            Destroy(destroyable);
            destroyIndex++;
        }
	}
}
