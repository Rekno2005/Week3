using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorShiftAndMove : MonoBehaviour {

    float delay = 10f;
    bool mousedown = false;

    float movedirection = 1;
    float moveamount = 0;

    // Use this for initialization
    void Start () {

        
		
	}
	
	// Update is called once per frame
	void Update () {
        //the next two conditionals are all about changing color states
        if(Time.time >delay && mousedown == false)
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, .5f, 1f);
        }

        if (Time.time < delay && mousedown == true)
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, .5f, 1f);
        }

        //this next conditional is all about making the thing move

        if(moveamount == 5f || moveamount == -5f)
        {
            movedirection = movedirection * -1f;
        }

        moveamount = moveamount + movedirection;

        transform.position = new Vector3(0f, 0f, moveamount);

    }

    private void OnMouseDown()
    {
        mousedown = true;
    }

    private void OnMouseUp()
    {
        mousedown = false;
    }
}

