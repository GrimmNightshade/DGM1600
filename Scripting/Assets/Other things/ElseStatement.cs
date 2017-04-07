using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseStatement : MonoBehaviour {
	
	public string animal = "Dog";

	// Use this for initialization
	void Start () {

		//Oh look hes doing the voice again! Better write it in my notes~
		//Hes also making a really long code.... Like a lot of code.... Unfortunatly we haven't talked about functions yet... Yay...
		if(animal=="Cat"){
			print ("Cat");
		}


		else{
			print("I have no clue what this animal is....");
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
