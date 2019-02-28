using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeaquaremove : MonoBehaviour {

    private Vector3 nextPos;

    public float corner;
    public float speed;
    public float dist;

	// Use this for initialization
	void Start () {
        corner = 1;
        speed = 1.0f;
        dist = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {

        if(corner >0 && corner < 1)

        {
            nextPos = new Vector3(speed, 0, 0);
        }

        if (corner > 1 && corner < 2)

        {
            nextPos = new Vector3(0, speed, 0);
        }

        if (corner > 2 && corner < 3)

        {
            nextPos = new Vector3(-speed, 0, 0);
        }

        if (corner > 3 && corner < 4)

        {
            nextPos = new Vector3(0, -speed, 0);
            
        }

        if (corner >= 4)
        {
            corner = 0;
        }

        transform.position = transform.position + nextPos;

        corner = corner + dist;
	}
}
