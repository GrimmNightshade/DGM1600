using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
	
	int i=0;
	public string[] colors;
	//[This is an aray] elements, arays, and general scripting starts at zero. Not one.

	// Use this for initialization
	void Start () 
	{
		while (i < colors.Length)
		{
			print(colors[i]);
			i++;
		}

		print ("Done");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
