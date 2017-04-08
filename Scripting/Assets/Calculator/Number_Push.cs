using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number_Push : MonoBehaviour {

    public Calculation C;
    public Total T;
    public Display D;
    public string numberButton;
 

    public void click() {
        switch(T.mode)
        {
            case 1:
                C.a = numberButton;
                D.textDisplay.text = C.a;
                break;
            case 2:
                C.b = numberButton;
                T.mode = 3;
                D.textDisplay.text = C.a + " " + C.mod + " " + C.b;
                break;
            case 3:
                C.b = numberButton;
                D.textDisplay.text = C.a + " "+ C.mod +" " + C.b;
                break;
        }
	}
}
