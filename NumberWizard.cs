using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	// Use this for initialization
	
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 13;
	
	public Text GuessText;
	
	void Start () {
		StartGame();
	}
	
	void StartGame() {
		
		max = 1001;
		min = 1;
		NextGuess();
		GuessText.text = "IS YOUR NUMBER HIGHER OR LESS THAN " + guess;

	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	public void GuessEqual(){
		Application.LoadLevel("Lose");
	}
	
	public void NextGuess() {
		guess = (Random.Range(min, max));
		GuessText.text = "IS YOUR NUMBER HIGHER OR LESS THAN " + guess;
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if(maxGuessesAllowed <= 0){
			Application.LoadLevel("Win");
		}
	}
}

