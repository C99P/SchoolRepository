using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementNum : MonoBehaviour {

    int num = 1;
    int min = 0;
    int max = 200;


    void InTo ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Value has added a '1'");
            num = num + 1;
            print(num);
        }
        else
            if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Value is decremented by 1");
            num = num - 1;
            print(num);
        }
        else
            if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Value is decremented by 10");
            num = num - 10;
            print(num);
        }
        else
            if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Value is incrmented by 10");
            num = num + 10;
            print(num);
        }
        else
            if (num <= 0)
        {
            print("You reached the limit");
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
            if (num >= 200)
        {
            print("You reached the limit");
            UnityEditor.EditorApplication.isPlaying = false;
        }

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        InTo();
    }
}
