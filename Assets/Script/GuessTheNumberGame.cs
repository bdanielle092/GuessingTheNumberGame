using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour {
    public InputField input;
    public Text infoText;

    private int guessNumber;
    private int usersGuess;

	// Use this for initialization
	void Start () {
        guessNumber = Random.Range(0, 100);
	}
	
	public void CheckGuess()
    {
        usersGuess = int.Parse(input.text);

        if(usersGuess == guessNumber)
        {
            infoText.text = "You Guess the Number, Congrats!";
        }else if( usersGuess > guessNumber)
        {
            infoText.text = "Your Number is Greater than the Guess Number";
        }else if( usersGuess < guessNumber)
        {
            infoText.text = "Your Number is lower than the Guess Number";
        }
        input.text = "";
    }
	
	
}
