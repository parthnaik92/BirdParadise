using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class GetInputFromUser : MonoBehaviour {

    public String[] player1keys = {"Q", "W", "E", "R", "A", "S", "D", "F", "Z", "X", "C", "V"};
    public String[] player2keys = {"Y", "U", "I", "O", "P", "H", "J", "K", "L", "B", "N", "M"};

    //Fuction to detect the key pressed by player
    public void detectPressedKey()
    {
        foreach(KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(keyCode))
            {
                Debug.Log("The key was " + keyCode);
                compareKeysWithKeySpace(keyCode);
            }
        }
    }

    //Function to compare the pressed key with both the KeySpaces to determine which player pressed the key
    void compareKeysWithKeySpace(KeyCode kCode)
    {
        for (int i = 0; i < player1keys.Length; i++)
        {
            if (kCode.ToString() == player1keys[i])
            {
                Debug.Log("Player One has pressed something");
                compareKeysWithDisplayedKeys(kCode);
            }
            else if (kCode.ToString() == player2keys[i])
            {
                Debug.Log("Player Two has pressed something");
                compareKeysWithDisplayedKeys(kCode);
            }
        }
    }

    void compareKeysWithDisplayedKeys(KeyCode kCode1)
    {
        //condition to compare the pressed key with randomely generated keys on the screen
        sendDataToLoveBar();
    }

    void sendDataToLoveBar()
    {

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        detectPressedKey();

    }
}
