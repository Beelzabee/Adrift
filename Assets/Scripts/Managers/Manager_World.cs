using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_World : MonoBehaviour {
	public static Manager_World world;

	/***MonoBehaviour Functions***/
	void Awake () {
		//This is the only gameManger on a GameObject
		if (world == null) {
			DontDestroyOnLoad (gameObject);
			world = this;
		} 
		//This is NOT the only gameManger on a GameObject
		else {
			Destroy (gameObject);
		}
	}

	// FIXME: This function takes a ship and determines whether it has
	// been split in two or more sections
	public void CheckShipForSplit () {
	}

	// FIXME: This function takes a ship that has been split and arranges
	// its remaining sections into new ships and debri
	public void ShipHasSplit () {
	}
}