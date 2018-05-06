using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Manager_Input : MonoBehaviour {
	public GameObject floor;
	public Vector3 currentPos { get; protected set; }
	bool mode_Build_Floor = true;

	void Update () {
		// Get Cursor position
		currentPos = Input.mousePosition;

		// Left Click
		if (Input.GetMouseButtonUp (0)) {
			// If over a UI element, bail out
//			if (EventSystem.current.IsPointerOverGameObject ()) {
//				return;
//			}
			// FIXME: Places a floor down under the mouse cursor
			if (mode_Build_Floor) {
				Debug.Log ("Build a floor");
				GameObject go = GameObject.Instantiate (floor, Camera.main.ScreenToWorldPoint(currentPos), Quaternion.identity);
			}
		}
	}
}