﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourDoorManager : MonoBehaviour {

	public static void TryOpen (Color playerColor, Color doorColor, Collision2D coll ) {
		if (playerColor.a == doorColor.a && playerColor.b == doorColor.b && playerColor.g == doorColor.g) {
			coll.collider.isTrigger = true;
		}
	}

	void OnTriggerExit2D (Collider2D other){
		// Deactivates trigger when player leaves the door's collider
		GetComponent<Collider2D> ().isTrigger = false;
	}
}
