using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float movementSpeed = 3.0f;
	public float gravity = 9.8f;

	private CharacterController myController;
	// Use this for initialization
	void Start () {
		myController = gameObject.GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 movementZ = Input.GetAxis ("Vertical") * Vector3.forward * movementSpeed * Time.deltaTime;
		Vector3 movementX = Input.GetAxis ("Horizontal") * Vector3.right * movementSpeed * Time.deltaTime;

		Vector3 movement = transform.TransformDirection(movementX + movementZ);
		movement.y -= gravity *Time.deltaTime; 

		myController.Move(movement);
	}
}
