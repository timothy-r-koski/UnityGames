using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int lowNumberLimit;
	int highNumberLimit;
	int currentGuess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)) {
			print("Your number is " + currentGuess + "!");
			StartGame();
		} else if(Input.GetKeyDown(KeyCode.UpArrow)) {
			lowNumberLimit = currentGuess;
			NextGuess();
		} else if(Input.GetKeyDown(KeyCode.DownArrow)) {
			highNumberLimit = currentGuess;
			NextGuess();
		}  

	}

	void StartGame() {
		lowNumberLimit = 1;
		highNumberLimit = 1000;
		currentGuess = 500;
		print("===============================================");
		print("Welcome to Number Wizard");
		print("Pick a number in your head but, don't tell me!");
		print("The highest number you can pick is: " + highNumberLimit);
		print("The lowest number you can pick is: " + lowNumberLimit);
		print("Is your number higher or lower than " + currentGuess + "?");
		print("Press up arrow for higher, down arrow for lower, and Enter for equal");
		highNumberLimit = highNumberLimit + 1;
	}

	void NextGuess() {
		currentGuess = (highNumberLimit + lowNumberLimit) / 2;
		print("Hummm.... is your number " + currentGuess + "?");
		print("Press up arrow for higher, down arrow for lower, and Enter for equal");
	}
}
