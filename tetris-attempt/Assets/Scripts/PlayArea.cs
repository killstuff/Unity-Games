using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour {

	public float moveDistance;
	public GameObject currentPiece;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Listen for keyboard controls
		// Check if collision
		// If so:
			// Check left/right collision:
				// No move
			// Check down collision:
				// No move, check row fill, copy currentPiece from preview window
				// If full:
					// delete row

		// Check if instance in preview window
		// If so:
			// Copy currentpiece from preview window, instantiate at random position/random rotation [0, 90 , 180, 270]
	}
}
