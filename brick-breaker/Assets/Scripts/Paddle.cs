﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 1f;

	private Vector3 playerPos = new Vector3 (0f, -9.5f, 0f);

	// Update is called once per frame
	void Update () {
		float xpos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xpos, -7.8f, 7.8f), -9.5f, 0f);
		transform.position = playerPos;
	}
}
