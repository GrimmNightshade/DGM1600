using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Total : MonoBehaviour {
    public int mode = 1;
    public float total;
    public Calculation C;
    public Display D;

    float Cek(float a, float b)
    {
        switch (C.mod)
        {
            case "+":
                return (a + b);
            case "-":
                return (a - b);
            case "*":
                return (a * b);
            case "/":
                return (a / b);
            default:
                return (a);
        }
    }
    public void go()
    {
        if (mode == 3)
        {
            total = Cek(C.numberA(), C.numberB());
            D.textDisplay.text = total.ToString();
            mode = 1;
        }
    }
}

