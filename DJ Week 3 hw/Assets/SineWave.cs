using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWave : MonoBehaviour {
	private Vector3 transformStart;
	public Vector3 currentPosition;

	// Use this for initialization
	void Start () {
		transformStart = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		currentPosition = new Vector3(transformStart.x + (Mathf.Sin (2 * Time.time * (Mathf.PI*2.0f))*2), transformStart.y + (Mathf.Cos (2 * (Time.time+1.0f) * (Mathf.PI*2.0f))*2), transformStart.z);
		transform.position = currentPosition;

	}

	void SinWaveMover() {
	}
}
