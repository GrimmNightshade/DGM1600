using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculation : MonoBehaviour {
    public string a;
    public string b;
    public string mod;

    public float numberA()
    {
        return float.Parse(a);
    }
    public float numberB()
    {
        return float.Parse(b);
    }
}