using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Total : MonoBehaviour {
    public int mode = 1;
    public float total;
    public Calculation C;
    public Display D;
    public Enemy_List E;

    public void go()
    {
        if (mode == 3)
        {
            total = C.Cek(C.numberA(), C.numberB());
            D.textDisplay.text = total.ToString();

            // Looks through Enemy list to see if the toal is equal to one of the enemies numbers.

            for (int i = 0; i < E.enemy.Count; i++)
            {  
                if (total == E.enemy[i])
                {
                    print("Got One," + "" + E.enemy[i]);
 
                }
            }
        }
      mode = 1;
   }
}


