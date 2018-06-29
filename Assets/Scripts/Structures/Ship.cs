using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	public Vector3 position () {
		return gameObject.transform.position;
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
