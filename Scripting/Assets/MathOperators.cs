using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

	public int addition = 12 + 4;
	public int subtraction = 12 - 4;
	public float division = 5/2f;
	public int multiplication = 10 * 2;
	public int remainder = 7 % 2;

	//Note Floats without the f at the end will round it. 

	// Use this for initialization

	void Start () {
		addition += 9;
		addition += 3;
		addition = 1;
		// += Adds to a current total.
		subtraction -= 10;
		subtraction -= 11;
		subtraction -= 14;
		subtraction -= 20 * 3;
		subtraction -= 7 + 3;



		// -= Subtracts from value's total.
	}
		
	// Update is called once per frame
	void Update () {
		
	}
}
