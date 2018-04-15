using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] pieceList;
	public GameObject currentPiece;
	// Use this for initialization
	void Start () {
		int randNum = Random.Range (0, pieceList.Length);
		currentPiece = Instantiate (pieceList [randNum], transform.position, Quaternion.identity);
		print (currentPiece.name);
	}
	
	// Update is called once per frame
	void Update () {
		// Check if there's another instance in play
		// If there is not another instance in play:
			// Copy currentPiece to play area
			// Destroy currentPiece
			// Instantiate new piece as currentPiece
		// If there is another instance in play, do nothing
	}
}
