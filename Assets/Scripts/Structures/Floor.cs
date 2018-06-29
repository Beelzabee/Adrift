using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Floor {
	// This floors neighbours
	public Action <Floor, string> northF, eastF, southF, westF;

	// Type, in case we have different materials
	string type;


}
