using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultSceneController: MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}

	public void pushbutton(){
		//Debug.Log ("シーン切り替え");
		switch(transform.name){
		case "RetryButton":
			SceneManager.LoadScene ("GameScene");
			break;
		case "TitleBackButton":
			SceneManager.LoadScene ("Title");
			break;
		}
	}
}
