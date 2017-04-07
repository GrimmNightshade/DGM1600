using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {

    public string userName = "Bob";

    //Private's can't be seen from the editor. It also can't be accessed from another class, unless is shares the same object.
    private string renter = "Kate";

    // This scope is local to an object. 
    //Awake can be used because it is avalable to monobehaviour/ Unity.
    //Imagine you are in a room with other boxes. One is Void one is awake.
    //Inside that box is another named if. You can see inside the box but you can't see outside of your own box. Same thing aplies here.
    void Awake () {

        //string is private. Meaning it can only be accessed inside its wake.
        string myName = "Joe";
        if (myName == "Joe")
        {
            string theirName = "Tim";
            print(renter);
            print(myName + "hates" + theirName);
        }
            print(myName);
            print(userName);
            print(renter);
	}
	
	// Update is called once per frame
	void Start () {
        string myName = "Frank";
        print(myName);
        print(userName);
	}
}
