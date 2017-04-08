using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Display : MonoBehaviour
{

    public Text textDisplay;

    private string test = "Yo";

    void Start()
    {
        //Note to self, Don't name the scripts with the word text in it. It causes problems with making edit text scripts.
        textDisplay.text = "Touch Button to begin: " + test;
    }


}
//C.a + C.b

