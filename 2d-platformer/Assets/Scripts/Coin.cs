using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	public float rotateSpeed = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		transform.Rotate (0, rotateSpeed, 0);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
		}
	}
}
