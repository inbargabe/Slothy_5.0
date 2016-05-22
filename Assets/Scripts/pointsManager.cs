﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pointsManager : MonoBehaviour {

	public static int flies;

	public Image flyBar;

	// Use this for initialization
	void Start () {
		flies = 0;
	}

	void Update() {
		
		switch (flies) {

		case 0:
			flyBar.fillAmount = 0f;
			break;
		
		case 1:
			flyBar.fillAmount = 0.33f;
			break;

		case 2:
			flyBar.fillAmount = 0.67f;
			break;

		case 3:
			flyBar.fillAmount = 1f;
			break;

		default:
			flyBar.fillAmount = 0f;
			break;
		}
	}

}
