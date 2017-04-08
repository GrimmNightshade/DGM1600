using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mods : MonoBehaviour {
    public Calculation C;
    public Total T;
    public Display D;

    public string Mod;

    public void press() 
    {
        if (T.mode <= 2)
        {
            T.mode = 2;
            C.mod = Mod;
            print("Setting... " + C.mod);
            D.textDisplay.text = C.a + " " + Mod;
        }
        else
        {
            print("Invalid");
        }
    }
}
