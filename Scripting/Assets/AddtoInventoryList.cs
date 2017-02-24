using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddtoInventoryList : MonoBehaviour {
	public Lists Inventory;
	public string myweapons;
	// Use this for initialization
	public void AddToList () {
		Inventory.weaponsList.Add(myweapons);
	}
	

}
