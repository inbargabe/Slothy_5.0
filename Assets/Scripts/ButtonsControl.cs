using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonsControl : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void Back(){
		SceneManager.LoadScene ("Levels");

	}
	public void Level1(){
		SceneManager.LoadScene ("Stage1");

	}
	public void Level2(){
		SceneManager.LoadScene ("Stage2");

	}
	public void Level3(){
		SceneManager.LoadScene ("Stage3");

	}
	public void Level4(){
		SceneManager.LoadScene ("Stage4");

	}
	public void Level5(){
		SceneManager.LoadScene("Stage5");

	}
}
