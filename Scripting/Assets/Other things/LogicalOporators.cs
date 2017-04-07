using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOporators : MonoBehaviour {

    public string string1;
    public string string2;
    public string Fun;
    public string LOVE;

    public string Favorate_Food;
    public string Favorate_Drink;
    public string Hated_Food;
    public string Hated_Drink;

    // Use this for initialization
    public void onButtonClick()
    {
        if (string1 == "Thing 1" && string2 == "Thing 2")
        {
            print("These are things are quite tame");
        }
        if (string1 == "Thing 1" || string2 == "Thing 2")
        {
            print("It's fun to have fun if you know what to do");
        }
        if (string1 != "Thing 1" && string2 != "Thing 2")
        {
            print("Oh what a shame, what a shame");
        }
    }
   
    public void FunValue()
    {
        if (Fun == "Fun" && LOVE == "LOVE")
        {
            print("Ahahah Idiot, Idiot, Idiot~");
        }
        if (Fun == "Fun" && LOVE != "LOVE")
        {
            print("☟︎♏︎●︎●︎□︎ 👍︎♒︎♓︎●︎♎︎📪︎ 🕈︎♒︎♋︎⧫︎ ♋︎❒︎♏︎ ⍓︎□︎◆︎ ♎︎□︎♓︎■︎♑︎ ♒︎♏︎❒︎♏︎✍︎");    
        }
        if (Fun != "Fun" && LOVE == "LOVE")
        {
            print("Hey kid. You do know what L.O.V.E means right? Of course you don't.");
        }
        if (Fun != "Fun" && LOVE != "LOVE")
        {
            print("Love and Fun.... Are values but in this case they are strings...");
        }
    }

    public void FoodDrink()
    {
        if(Hated_Food == Favorate_Food && Hated_Drink == Favorate_Drink)
        {
            print("You Just Had To Didn't You?");
        }

        if(Hated_Drink == Hated_Food || Favorate_Food == Favorate_Drink)
        {
            print("Oh Joy it looks like we have a joker here.");
        }

        if (Hated_Food == Favorate_Food && Hated_Drink == Favorate_Drink)
            {
                print("Are you just playing with more or are you being serious?");
            }
        if (Hated_Drink != Favorate_Drink && Hated_Food != Favorate_Food)
        {
            print("Really? Thats Interesting.");
        }
        else
        {
            print("Okay hun what ever you say");
        }
    }
}
	