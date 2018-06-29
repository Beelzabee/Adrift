using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Manager_Input : MonoBehaviour {
	enum Mode { None, Floor_Build, Floor_Remove };
	public GameObject floor;
	public Vector3 currentPos { get; protected set; }
	Mode mode = Mode.None;

	void Update () {
		// Get Cursor position
		currentPos = Input.mousePosition;
		if (mode == Mode.Floor_Build) {
			Physics2D.BoxCast
			//Cast a detector for other floors
			// Snap to whatever edge is closest
		}
		// Left Click
		if (Input.GetMouseButtonUp (0)) {
			// If over a UI element, bail out
			if (EventSystem.current.IsPointerOverGameObject ()) {
				return;
			}
			// FIXME: Places a floor down under the mouse cursor
			if (mode == Mode.Floor_Build) {
				Debug.Log ("Build a floor");
				GameObject go = GameObject.Instantiate (floor, Camera.main.ScreenToWorldPoint(currentPos), Quaternion.identity);
			}
			if (mode == Mode.Floor_Remove) {
				Debug.Log ("Remove a floor");

			}
		}
	}

	public void FloorsBuild () {
		mode = Mode.Floor_Build;
	}

	public void FloorsRemove () {
		mode = Mode.Floor_Remove;
	}
}