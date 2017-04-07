using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Tempature : MonoBehaviour {

public float temp = 50.0f;

   // Each of the void functions can be called seporatly which helps with debuging.s

    void cTempConvert()
    {
        float cTemp = temp;
        cTemp = ((cTemp - 32) * 5 / 9);
        print("Celsius Temp is" + cTemp);
    }
    void fTempConvert()
    {
        float fTemp = temp;
        fTemp = ((fTemp * 9 / 5)+32);
        print("Fahrenheit Temp is" + fTemp);
    }
    void Chill()
    {
        if (temp <= 0)
            print("Its frozen.");
        else
            print("Not frozen");
    }
    void Boiling()
    {
        if (temp >= 100) 
        print("Its Boiling");
        else
        print("Its not Boiling yet.");
    }
    
    void Trouble()
    {
        if (temp >= 1000)
            print("Its" + temp + "Degrees Run!");
        else
            print("I think were safe.");
    }
       
}

