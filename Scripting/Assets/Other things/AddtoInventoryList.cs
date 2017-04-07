using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddtoInventoryList : MonoBehaviour {
    public Inventory I;
    public string myweapons;

    public void AddInventoryList() {
        
            I.weaponsList.Add(myweapons);
    }
}
