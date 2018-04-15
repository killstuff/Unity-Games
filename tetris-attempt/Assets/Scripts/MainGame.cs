using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour {

	public GameObject PreviewWindow;
	public GameObject PlayArea;

	// Use this for initialization
	void Start () {
		// Schedule startup events:
		// Instantiate preview window then play area
		Instantiate(PreviewWindow, transform.position, Quaternion.identity);
		Instantiate (PlayArea, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
