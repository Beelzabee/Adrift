using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_World : MonoBehaviour {
	public static Manager_World world;

	/***MonoBehaviour Functions***/
	void Awake () {
		//This is the only Manager_World on a GameObject
		if (world == null) {
			DontDestroyOnLoad (gameObject);
			world = this;
		} 
		//This is NOT the only Manager_World on a GameObject
		else {
			Destroy (gameObject);
		}
	}

	public World BuildWorld () {
		World world = new World ();

		return world;	
	}

	// Build stars/planets/asteroids/etc
	void BuildEnvironment () {
	}

	// Build any ships/stations/buildings
	void BuildStructures () {
	}
}