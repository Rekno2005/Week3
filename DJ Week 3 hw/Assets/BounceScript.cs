using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour {

		private Vector3 transformStart;
		public Vector3 currentPosition;

		// Use this for initialization
		void Start () {
			transformStart = transform.position;
		}

		// Update is called once per frame
		void Update () {
		currentPosition = new Vector3(transformStart.x, transformStart.y + Mathf.Abs((Mathf.Sin (0.5f * (Time.time) * (Mathf.PI*2.0f))*4
	)), transformStart.z);
			transform.position = currentPosition;

		}

		void SinWaveMover() {
		}
	}

