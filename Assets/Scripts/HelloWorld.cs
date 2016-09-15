using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World");
		//Application.targetFrameRate = 30; this is how to cap framerates
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Bonjour monde");
	}
}
