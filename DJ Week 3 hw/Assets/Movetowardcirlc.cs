using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetowardcirlc : MonoBehaviour {

    public GameObject sphere;

    private Vector3 spherepos;
    private Vector3 cubePos;
    private Vector3 newpos;

    public float speed;

	// Use this for initialization
	void Start () {

        speed = .1f;
		
	}
	
	// Update is called once per frame
	void Update () {

        cubePos = transform.position;
        spherepos = sphere.transform.position;

        newpos = spherepos - cubePos;
        newpos = (newpos.normalized) * speed;
    

        transform.position = cubePos + newpos;


	}
}
