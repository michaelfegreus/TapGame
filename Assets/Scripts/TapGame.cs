using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Allows you to easily access unity UI

public class TapGame : MonoBehaviour {

	int score = 0; //player's current score 
	Text myText; //UnityEngine.UI.Text is another way to access without the "using" declaration on line 3, but it's better to declare it if you are talkingto the UI a lot.


	// Use this for initialization
	void Start () {
		// assign and cache the reference to the Text component.
		myText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		// Update text contents with current sclore (and game instructions?)
		myText.text = "TAPPY GAME! TAP [SPACE] TO WIN! CURRENT SCORE: " + score.ToString();

		// Add 1 point every time we tap Spacebar
		if (Input.GetKeyDown(KeyCode.Space)) { // Use "KeyCode.---" instead of "space" for more processing efficiency.
			//score++;
			//score = score + 1;
			score += 1; // Useful varient because it's easy to tune the numbers for gameplay this way.
		}
	}
}
