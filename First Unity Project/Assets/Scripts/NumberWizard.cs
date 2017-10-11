using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    //Variables
    int max = 1001;
    int min = 1;
    int guess = 500;

    void NextGuess () {
        print("Is the number greater than " + guess + "?");
        print("Press up if is bigger");
        print("Press down if smaller");
        print("Press enter if number is guessed");
    }

    void StartGame() {
        // Game output
        print("Welcome to Number Wizard");
        print("Please choose a number between " + min + " and " + max + "");
        NextGuess();
    }
    // Use this for initialization
    void Start () {
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("UpArrow pressed");
            min = guess;
            guess = (max + min) / 2;
            print("Bigger or smaller than " + guess + "?");
        }
        else
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("DownArrow pressed");
            max = guess;
            guess = (max + min) / 2;
            print("Bigger or smaller than " + guess + "?");
        }
        else
         if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter pressed");
            print("Number guessed!");
            print("(P)lay again or (Q)uit");
        }
        else
            if (Input.GetKeyDown(KeyCode.P))
        {
            StartGame();
        }
        else
            if (Input.GetKeyDown(KeyCode.Q))
        {
            UnityEditor.EditorApplication.isPlaying = false;
            print("Goodbye!");
        }
        
    }
}
