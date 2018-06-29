using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_UI : MonoBehaviour {
	Manager_Game manager_Game;
	// Use this for initialization
	void Start () {
		manager_Game = gameObject.GetComponent<Manager_Game> ();

	}
}
