using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour {

	// String is a data type that uses a string words/letters. Must use quotations. All variables must be one word and starts in LowerCase and every new word is capitalized.
	// Strings can't be identified with a numeric value.

	public string myString = "Hello World";
	public string myOtherString = "1";
	// Int is a data type that uses whole numbers. 
	public int myInt = 1;
	// Float is any number that isn't a whole number. They must have an f at the end. Doubles are invalid in unity.
	public float myFloat = 1.2f;
	//bools stand for boolian and it is either true or false.
	public bool myBool = false;


	// Use this for initialization
	void Start () {
		print ("Hello World");
	}

	// Update is called once per frame
	void Update () {

	}
}
