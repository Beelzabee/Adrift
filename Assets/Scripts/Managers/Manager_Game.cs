using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Game : MonoBehaviour {
	public static Manager_Game manager_Game;
	Manager_World manager_World;
	World world;

	/***MonoBehaviour Functions***/
	void Awake () {
		//This is the only gameManger on a GameObject
		if (manager_Game == null) {
			DontDestroyOnLoad (gameObject);
			manager_Game = this;
		} 
		//This is NOT the only gameManger on a GameObject
		else {
			Destroy (gameObject);
		}
	}

	void Start () {
		manager_World = GameObject.Find ("World").GetComponent<Manager_World> ();
		world = manager_World.BuildWorld ();
	}
}