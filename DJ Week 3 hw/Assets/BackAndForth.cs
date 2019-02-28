using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour {
	private Vector3 spherePosition;
	public float sphereXPos = 0.0f;
	public float speed;
	public bool movingRight;
	public Vector3 startingPosition;
	public float boundsLeftRight;

	// Use this for initialization
	void Start () {
		movingRight = true;
		startingPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (sphereXPos <= boundsLeftRight && movingRight) {
			sphereXPos = sphereXPos + (speed * Time.deltaTime);
		} else {
			sphereXPos = sphereXPos - (speed * Time.deltaTime);
			movingRight = false;
		}

		if (sphereXPos <= -boundsLeftRight) {
			movingRight = true;
		}

		spherePosition = new Vector3 (startingPosition.x + sphereXPos, startingPosition.y, startingPosition.z);
		transform.position = spherePosition;
	}
}
