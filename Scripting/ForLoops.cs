using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ForLoops : MonoBehaviour
{

    public int Moven = 90;
    public int Zombies = 50;


    // Use this for initialization
    void Start()
    {
        //For loops allow for the end conditions to be specified within the parenthises~ ()
        for (int spawn = 0; spawn < Zombies; spawn++)
        {
            print(spawn);

        }

        print("Zombies are invaiding!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.Rotate(0, 0.1f, 0);
            transform.Rotate(0, 0, 0.1f);

       
    }
}
