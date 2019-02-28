using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameJoystick : MonoBehaviour {
	public Transform joystickTip;
	public Transform joystickBase;
	public Vector3 joystickVector;
	public float speed;
	public Vector3 joystickVectorNormalized;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		joystickVector = joystickTip.position - joystickBase.position;
		transform.position = transform.position + (joystickVector * speed * Time.deltaTime);
		joystickVectorNormalized = joystickVector.normalized;

	}
}
