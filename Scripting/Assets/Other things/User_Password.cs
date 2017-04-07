using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User_Password : MonoBehaviour {
	public string password;
	public bool userAgreement;

	// Use this for initialization
	void Start () {
		//if somthing has more than two outcomes and or has a  then avoid using if statments.
		if(password == "NotSecurePassword" && userAgreement) {
			print ("Correct");
		}
		else
		{
			print("Incorrect");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
