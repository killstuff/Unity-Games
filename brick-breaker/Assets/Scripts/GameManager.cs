using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int lives = 3;
	public int bricks = 24;
	public float resetDelay = 1f;
	public Text livesText;
	public GameObject gameOver;
	public GameObject youWon;
	public GameObject bricksPrefab;
	public GameObject paddle;
	public GameObject deathParticles;
	public static GameManager instance = null;
	private GameObject clonePaddle;
	private GameObject ball;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		Setup ();
	}

	public void Setup(){
		SetupPaddle ();
		Instantiate (bricksPrefab, transform.position, Quaternion.identity);
	}

	void CheckGameOver(){
		if (bricks <1) {
			youWon.SetActive (true);
			Time.timeScale = .25f;
			Invoke ("Reset", resetDelay);
		}
		if (lives < 1) {
			gameOver.SetActive (true);
			Time.timeScale = .25f;
			Invoke ("Reset", resetDelay);
		}
	}

	void Reset(){
		Time.timeScale = 1f;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
	
	public void LoseLife(){
		lives--;
		livesText.text = "Lives: " + lives;
		Instantiate (deathParticles, clonePaddle.transform.position, Quaternion.identity);
		Destroy (clonePaddle);
		Destroy (ball);
		Invoke ("SetupPaddle", resetDelay);
		CheckGameOver ();
	}

	void SetupPaddle(){
		clonePaddle = Instantiate (paddle, transform.position, Quaternion.identity) as GameObject;
		ball = clonePaddle.transform.Find ("Ball").gameObject;
	}

	public void destroyBrick() {
		bricks--;
		CheckGameOver();
	}
}
