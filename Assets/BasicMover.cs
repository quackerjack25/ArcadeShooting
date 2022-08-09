using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour {
	
	public enum motionDirection{Horizontal, Vertical, Spin};
	public motionDirection motionState;
	public float spinSpeed = 180.0f;
	public float motionMagintude =0.1f;



	// Update is called once per frame
	void Update () {
		if (motionState == motionDirection.Spin)
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		if(motionState == motionDirection.Vertical)
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagintude);
		if(motionState == motionDirection.Horizontal)
			gameObject.transform.Translate (Vector3.right * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagintude);
	}
}
