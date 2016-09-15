using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Application.targetFrameRate = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			// Move forward if I press W
			// transform.position.z += 1f; DOES NOT WORK do not use, it's based on structs and you cannot move structs on the memory
			//transform.position += new Vector3( 0f, 0f, 10f * Time.deltaTime); // Make sure that you have the += to do ascending values and "new." Problem with this line is that Cube still moves in world space, not local space like we want it to.
			transform.Translate( 0f, 0f, 1f );
			// ***Multiply by Time.deltaTime to get Framerate Independent Behavior. This is crucial so that the gameplay and numbers are even DESPITE lower framerates.
		}

		if (Input.GetKey (KeyCode.A)) {
			// Tank controls
			// Do NOT do transform.rotation, we do not want to mess with quanternian four dimentional stuff
			transform.eulerAngles += new Vector3( 0f, -5f, 0f ); //euler is pronounced "oiler," because it's a Dutch word.
			//Euler angles don't require " * Time.deltaTime" because they work independent of the framerate
			//transform.Rotate( 0f, -5f, 0f); more intuitive way to turn left? But this form can't do more complex functions like use variables to adjust movement.
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.eulerAngles += new Vector3 (0f, 5f, 0f);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0f, 0f, -10f * Time.deltaTime);
		}
		// Test it, never to soon to test.
	}
}
