﻿using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {

	public GameObject pauseScreen;
	public SpriteRenderer spriteRenderer;
	public bool paused;


	// Use this for initialization
	void Start () {
		paused = false;
		spriteRenderer = pauseScreen.GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {


	}

	public void Pause(){
			paused = !paused;
		if (paused) {
			Time.timeScale = 0;
			spriteRenderer.enabled = true;
		} else if (!paused) {
			Time.timeScale = 1;
			spriteRenderer.enabled = false;
		}

	}
}
